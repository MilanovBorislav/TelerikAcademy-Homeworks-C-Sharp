using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public class Discipline:IComentable
    {
        public string disciplineName;
        public int numberOfLuctures;
        public int numberOfExercises;

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

        public int NumberOfLuctures
        {
            get
            {
                return this.numberOfLuctures;
            }
            set
            {

                if( value > 50 && value < 5 )
                {
                    throw new Exception( "Invalid number of exercises" );
                }

                this.numberOfLuctures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {

                if( value > 50 && value < 5 )
                {
                    throw new Exception( "Invalid number of exercises" );
                }

                this.numberOfExercises = value;
            }
        }

        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                if( value == null )
                {
                    throw new ArgumentNullException();
                }

                this.disciplineName = value;
            }
        }

        public Discipline(string name, int numLectures, int numExercises)
        {
            this.DisciplineName = name;
            this.NumberOfLuctures = numLectures;
            this.NumberOfExercises = numExercises;
            this.comments = new List<string>();
        }

        internal void ShowDiscipline()
        {
            Console.WriteLine();
            Console.WriteLine( "Discipline name :      {0}", this.DisciplineName );
            Console.WriteLine( "Number of lecture :    {0}", this.NumberOfLuctures );
            Console.WriteLine( "Number of exercises :  {0}", this.numberOfExercises );
        }

        public void AddComment(string comment)
        {
            Comments.Add( comment );
        }

        public void ShowComments()
        {
            Console.WriteLine();
            Console.WriteLine( "Comments for discipline {0}", this.DisciplineName );

            foreach( var item in this.comments )
            {
                Console.WriteLine( item );
            }
        }
    }
}
