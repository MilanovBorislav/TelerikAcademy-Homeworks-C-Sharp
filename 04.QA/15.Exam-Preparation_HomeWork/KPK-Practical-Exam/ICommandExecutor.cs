namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public interface ICommandExecutor
    {
        void ExecuteCommand(ICatalog contentCatalog, ICommand command, StringBuilder output);
    }
}