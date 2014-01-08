using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public class Teacher:Person, IComentable
    {
        private List<Discipline> disciplineList;
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

        public Teacher(string name)
            : base( name )
        {

            disciplineList = new List<Discipline>();
            comments = new List<string>();
        }

        public void AddDiscipline(Discipline someDiscipline)
        {

            this.disciplineList.Add( someDiscipline );

        }

        public void ShowTeachersDiscipline()
        {
            Console.WriteLine();
            Console.WriteLine( "Teacher {0} teach", this.Name );

            for( int i = 0; i < this.disciplineList.Count; i++ )
            {
                this.disciplineList[i].ShowDiscipline();
            }
        }

        internal void ShowTeacher()
        {
            Console.WriteLine( this.Name );
        }

        public void AddComment(string comment)
        {
            Comments.Add( comment );
        }

        public void ShowComments()
        {
            Console.WriteLine();
            Console.WriteLine( "Comments for teacher {0}", this.Name );

            foreach( var item in this.comments )
            {
                Console.WriteLine( item );
            }
        }

    }
}
