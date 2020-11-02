﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;
using Hygge_discord_bot.Attributes;
using Hygge_discord_bot.Handlers.Dialogue;
using Hygge_discord_bot.Handlers.Dialogue.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Hygge_discord_bot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        [Description("Returns pong")]
        [RequireCategorie(ChannelCheckMode.Any, "TekstKanaler")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("pong").ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Adds two numbers together")]
        //[RequireRoles(RoleCheckMode.All, "Moderator", "Owner")]
        public async Task Add(CommandContext ctx,
            [Description("First Number")] int numberOne,
            [Description("Second Number")] int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo)
                .ToString())
                .ConfigureAwait(false);
        }

        [Command("respondmessage")]
        public async Task Respondmessage(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Content);

        }

        [Command("dialogue")]
        public async Task dialogue(CommandContext ctx)
        {
            var inputStep = new TextStep("Enter Something interesting!", null);
            var funnyStep = new IntStep("Haha, funny", null, maxValue: 100);

            string input = string.Empty;
            int value = 0;

            inputStep.OnValidResult += (result) =>
            {
                input = result;

                if (result == "something interesting")
                {
                    inputStep.SetNextStep(funnyStep);
                }
            };

            funnyStep.OnValidResult += (result) => value = result;

            var userChannel = await ctx.Member.CreateDmChannelAsync().ConfigureAwait(false);

            var inputDialogueHandler = new DialogueHandler(
                ctx.Client,
                userChannel,
                ctx.User,
                inputStep
            );

            bool succeeded = await inputDialogueHandler.ProcessDialogue().ConfigureAwait(false);

            if (!succeeded) { return; }

            await ctx.Channel.SendMessageAsync(input).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(value.ToString()).ConfigureAwait(false);
        }
    }
}
