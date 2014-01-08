using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public class Student:Person, IComentable
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if( value.ToString().Length < 5 )
                {
                    throw new Exception( "Number must be more than 4 numbers" );
                }
                this.classNumber = value;

            }
        }

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
        public Student(string name, int classNumber)
            : base( name )
        {
            this.ClassNumber = classNumber;
            this.comments = new List<string>();

        }
        public void AddComment(string comment)
        {
            Comments.Add( comment );
        }

        public void ShowComments()
        {
            Console.WriteLine();
            Console.WriteLine( "Comments for student {0}", this.Name );

            foreach( var item in this.comments )
            {
                Console.WriteLine( item );
            }
        }
    }
}
