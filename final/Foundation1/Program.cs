using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1 Information
        // Creates Comments
        Comment _c1 = new Comment("Kami", "Very Interesting...");
        Comment _c2 = new Comment("Wendy", "I love potatoes");
        Comment _c3 = new Comment("Kate", "Thank you! This helped my college student so much!");
        Comment _c4 = new Comment("PotatoLover123", "Best potato I've ever had!");
        // Put Comments in a List
        List<Comment> _potatoCs = new List<Comment>{_c1, _c2, _c3, _c4};
        // Other Video Information
        string _titleP = "How to Cook a Potato";
        string _authorP = "Potato Man";
        double _durationP = 10.2;
        //Create Video
        Video _potatoV = new Video(_titleP, _authorP, _durationP, _potatoCs);


        // Video 2 Infomation
        // Creates Comments
        Comment _c5 = new Comment("AlphaW", "You will never be as alpha as me");
        Comment _c6 = new Comment("Lani", "*stab* *dab* *dab* *dab*");
        Comment _c7 = new Comment("PugLoverRules5793", "That was so funny when you stole that kids exotic knife");
        Comment _c8 = new Comment("Xx_LoganPaulKid_xX", "Drinking my Prime Energy and eating my Lunchly while watching, life could not be better");
        // Put Comments in a List
        List<Comment> _robloxCs = new List<Comment>{_c5, _c6, _c7, _c8};
        // Other Video Information
        string _titleR = "Crazy Roblox Murderer";
        string _authorR = "MyMommyToldMeNo";
        double _durationR = 20.7;
        //Create Video
        Video _robloxV = new Video(_titleR, _authorR, _durationR, _robloxCs);


        // Video 3 Infomation
        // Creates Comments
        Comment _c9 = new Comment("RegularUSAMan", "USA! USA! USA! BEER! BEER! BEER!");
        Comment _c10 = new Comment("LittleGirl", "Can I pet that dawg?!");
        Comment _c11 = new Comment("Babushka", "U r very strong man reminds me of my baby boy");
        // Put Comments in a List
        List<Comment> _bearCs = new List<Comment>{_c9, _c10, _c11};
        // Other Video Information
        string _titleB = "How to Wrestle a Grizzly Bear";
        string _authorB = "RegularRussianManVodka28";
        double _durationB = 60.0;
        //Create Video
        Video _bearV = new Video(_titleB, _authorB, _durationB, _bearCs);

        // Create List of Videos 
        List<Video> Videos = new List<Video>{_potatoV, _robloxV, _bearV};


        // For each video diplay the information and amount of comments
        foreach (Video V in Videos)
        {
            V.DiplayVideoInformation();
            Console.WriteLine();
        }
    }
}