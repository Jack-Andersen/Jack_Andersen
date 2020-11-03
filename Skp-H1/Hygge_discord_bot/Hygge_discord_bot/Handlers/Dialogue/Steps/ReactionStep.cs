﻿using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Handlers.Dialogue.Steps
{
    public class ReactionStep : DialogueStepBase
    {
        private readonly Dictionary<DiscordEmoji, ReactionStepData> _options;

        private DiscordEmoji _selectedEmoji;

        public ReactionStep(string conDictionary, Dictionary<DiscordEmoji, ReactionStepData> options) : base(conDictionary)
        {
            _options = options;
        }

        public override IDialogueStep NextStep => _options[_selectedEmoji].NextStep;

        public Action<DiscordEmoji> OnValidResult { get; set; } = delegate { };

        public override async Task<bool> ProcessStep(DiscordClient client, DiscordChannel channel, DiscordUser user)
        {
            var cancelEmoji = DiscordEmoji.FromName(client, ":x:");

            var embedbuilder = new DiscordEmbedBuilder
            {
                Title = $"Please React To This Embed",
                Description = $"{user.Mention}, {_content}",
            };

            embedbuilder.AddField("To Stop The Dialogue", "React With the :x: emoji");

            var interactivity = client.GetInteractivity();

            while (true)
            {
                var embed = await channel.SendMessageAsync(embed: embedbuilder).ConfigureAwait(false);

                OnMessageAdded(embed);

                foreach(var emoji in _options.Keys)
                {
                    await embed.CreateReactionAsync(emoji).ConfigureAwait(false);
                }

                await embed.CreateReactionAsync(cancelEmoji).ConfigureAwait(false);

                var reactionResult = await interactivity.WaitForReactionAsync(
                    x => _options.ContainsKey(x.Emoji) || x.Emoji == cancelEmoji,
                    embed,
                    user).ConfigureAwait(false);

                if (reactionResult.Result.Emoji == cancelEmoji)
                {
                    return true;
                }

                _selectedEmoji = reactionResult.Result.Emoji;

                OnValidResult(_selectedEmoji);

                return false;

            }
        }
    }

    public class ReactionStepData
    {

        public string Content { get; set; }

        public IDialogueStep NextStep { get; set; }
    }

}
