using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public interface IComentable
    {

        List<string> Comments { get; set; }
        void AddComment(string comment);

        void ShowComments();

    }
}
