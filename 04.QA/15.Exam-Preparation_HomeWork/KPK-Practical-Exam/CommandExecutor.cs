namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    ProcessAddBookCommand(catalog, command, output);
                    break;
                case CommandType.AddMovie:
                    ProcessAddMovieCommand(catalog, command, output);
                    break;
                case CommandType.AddSong:
                    ProcessAddSongCommand(catalog, command, output);
                    break;
                case CommandType.AddApplication:
                    ProcessAddApplicationCommand(catalog, command, output);
                    break;
                case CommandType.Update:
                    ProcessUpdateCommand(catalog, command, output);
                    break;
                case CommandType.Find:
                    ProcessFindCommand(catalog, command, output);
                    break;
                default:
                    throw new InvalidOperationException("Unknown command!");
            }
        }

        private static void ProcessAddBookCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            var item = new ContentItem(ContentItemType.Book, command.Parameters);
            catalog.Add(item);
            output.AppendLine("Books Added");
        }

        private static void ProcessAddMovieCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            catalog.Add(new ContentItem(ContentItemType.Movie, command.Parameters));
            output.AppendLine("Movie added");
        }

        private static void ProcessAddSongCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            catalog.Add(new ContentItem(ContentItemType.Song, command.Parameters));
            output.AppendLine("Song added");
        }

        private static void ProcessAddApplicationCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            catalog.Add(new ContentItem(ContentItemType.Application, command.Parameters));
            output.AppendLine("Application added");
        }

        private static void ProcessUpdateCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new ArgumentException("Invalid Parameters!");
            }

            string oldUrl = command.Parameters[0];
            string newUrl = command.Parameters[1];
            int itemsUpdated = catalog.UpdateContent(oldUrl, newUrl);

            output.AppendLine(String.Format("{0} items updated", itemsUpdated));
        }

        private static void ProcessFindCommand(ICatalog catalog, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new ArgumentException("Invalid number of parameters!");
            }

            int numberOfElementsToList = int.Parse(command.Parameters[1]);

            IEnumerable<IContentItem> foundContent = catalog.GetListContent(command.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() == 0)
            {
                output.AppendLine("No items found");
            }
            else
            {
                foreach (IContentItem content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }
            }
        }
    }
}