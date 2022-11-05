using System.Diagnostics.Contracts;

namespace PersonalSite.Pages
{
    public partial class Goals
    {
        public String date;
        public String goal;
        public String why;
        private void DisplayGoal()
        {
            int randomGoal = Random.Shared.Next(1, goals.Length);
            date = goals[randomGoal].Date;
            goal = goals[randomGoal].Goal;
            why = goals[randomGoal].Why;
            

        }
    }
}
