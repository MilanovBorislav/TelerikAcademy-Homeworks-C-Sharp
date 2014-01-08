using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public class StudentClass:IComentable
    {
        private List<Teacher> techersList = new List<Teacher>();
        private string textIdentiefier;


        private List<string> comments;

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                if( value == null )
                {
                    throw new ArgumentNullException();
                }
                this.comments = value;
            }
        }
        public string TextIdentiefier
        {
            get
            {
                return this.textIdentiefier;
            }
            private set
            {

                if( value == null )
                {
                    throw new ArgumentNullException();
                }
                this.textIdentiefier = value;
            }
        }

        public StudentClass(string textident)
        {
            this.TextIdentiefier = textident;
            this.comments = new List<string>();

        }

        public void AddTeacher(Teacher someTeacher)
        {
            techersList.Add( someTeacher );
        }

        public void ShowTeachers()
        {
            Console.WriteLine( "Teachers in class {0}", this.TextIdentiefier );
            foreach( var item in this.techersList )
            {
                item.ShowTeacher();
            }
        }

        public void AddComment(string comment)
        {
            Comments.Add( comment );
        }

        public void ShowComments()
        {
            Console.WriteLine();
            Console.WriteLine( "Comments for class {0}", this.TextIdentiefier );

            foreach( var item in this.comments )
            {
                Console.WriteLine( item );
            }
        }
    }
}
