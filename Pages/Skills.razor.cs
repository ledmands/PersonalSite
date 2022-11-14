namespace PersonalSite.Pages
{
    public partial class Skills
    {


        
        public async Task ShowSkill()
        {

            currentColor = "skill-card-pink";

            await Task.Delay(3000);

            currentColor = "skill-card-black";


        }
        
    }
}
