namespace PersonalSite.Pages
{
    public partial class Skills
    {
        public String colorTile1 = "skill-card-black";
        public String colorTile2 = "skill-card-black";
        public String colorTile3 = "skill-card-black";
        public String colorTile4 = "skill-card-black";
        public String colorTile5 = "skill-card-black";
        public String colorTile6 = "skill-card-black";


        public async Task ShowSkill(int tileClicked)
        {
            
            switch (tileClicked)
            {
                case 1:
                    colorTile1 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile1 = "skill-card-black";
                    break;
                case 2:
                    colorTile2 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile2 = "skill-card-black";
                    break;
                case 3:
                    colorTile3 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile3 = "skill-card-black";
                    break;
                case 4:
                    colorTile4 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile4 = "skill-card-black";
                    break;
                case 5:
                    colorTile5 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile5 = "skill-card-black";
                    break;
                case 6:
                    colorTile6 = "skill-card-pink";
                    await Task.Delay(3000);
                    colorTile6 = "skill-card-black";
                    break;

            }


            // switch depending on which tile is passed in
        }
        
    }
}
