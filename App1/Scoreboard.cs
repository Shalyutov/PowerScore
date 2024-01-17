using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Scoreboard
    {
        public ObservableCollection<Participant> Participants { get; set; }
        public ObservableCollection<Vote> Votes { get; set; }
        public ObservableCollection<int> VotingMarks { get; set; }
        public ObservableCollection<string> Juries { get; set; }
        public ObservableCollection<string> Countries { get; set; }
        
        public Scoreboard()
        { 
            Participants = new ObservableCollection<Participant>();
            Votes = new ObservableCollection<Vote>();
            VotingMarks = new ObservableCollection<int>();
            Countries = new ObservableCollection<string>();
            Juries = new ObservableCollection<string>();
        }
    }
}
