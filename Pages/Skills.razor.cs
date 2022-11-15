namespace PersonalSite.Pages
{
    public partial class Skills
    {
        private static String tileCover = "skill-tile-covered";
        private static String tileDisplay = "skill-tile-displayed";
        private static String coveredImage = "images/skills/tileCover.png";

        // should make these private
        public String colorTile1 = tileCover;
        public String colorTile2 = tileCover;
        public String colorTile3 = tileCover;
        public String colorTile4 = tileCover;
        public String colorTile5 = tileCover;
        public String colorTile6 = tileCover;

        public String tileImage1 = coveredImage;
        public String tileImage2 = coveredImage;
        public String tileImage3 = coveredImage;
        public String tileImage4 = coveredImage;
        public String tileImage5 = coveredImage;
        public String tileImage6 = coveredImage;



        public async Task ShowSkill(int tileClicked)
        {
            
            switch (tileClicked)
            {
                //juggling
                case 1:
                    colorTile1 = tileDisplay;
                    tileImage1 = "images/skills/juggling.gif";
                    await Task.Delay(3000);
                    tileImage1 = coveredImage;
                    colorTile1 = tileCover;
                   break;
                
                //c#
                case 2:
                    colorTile2 = tileDisplay;
                    tileImage2 = "images/skills/code.gif";
                    await Task.Delay(3000);
                    tileImage2 = coveredImage;
                    colorTile2 = tileCover;
                    break;
                
                //box
                case 3:
                    colorTile3 = tileDisplay;
                    tileImage3 = "images/skills/box.gif";
                    await Task.Delay(3000);
                    tileImage3 = coveredImage;
                    colorTile3 = tileCover;
                    break;
                
                //html
                case 4:
                    colorTile4 = tileDisplay;
                    tileImage4 = "images/skills/html.gif";
                    await Task.Delay(3000);
                    tileImage4 = coveredImage;
                    colorTile4 = tileCover;
                    break;
               
                //drums
                case 5:
                    colorTile5 = tileDisplay;
                    tileImage5 = "images/skills/drums.gif";
                    await Task.Delay(3000);
                    tileImage5 = coveredImage;
                    colorTile5 = tileCover;
                    break;
                
                //linux
                case 6:
                    colorTile6 = tileDisplay;
                    tileImage6 = "images/skills/linux.gif";
                    await Task.Delay(3000);
                    tileImage6 = coveredImage;
                    colorTile6 = tileCover;
                    break;

            }


        }
        
    }
}
