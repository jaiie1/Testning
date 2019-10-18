using System;

namespace Test
{
    public class Post
    {
        private string _title { get; set; }

        private string _description { get; set; }

        private DateTime _posted { get; set; }

        public string Title
        {
            get { return _title;}
            set { _title = value; }
        }

        public string Description
        {
            get { return _description;}
            set { _description = value; }
        }

        public DateTime Posted
        {
            get { return _posted; }
            set { _posted = DateTime.Now;}
        }

        public int VoteValue { get; private set; }


        public void UpVote()
        {
            VoteValue += 1;
        }

        public void DownVote()
        {
            VoteValue -= 1;
        }
    }
}