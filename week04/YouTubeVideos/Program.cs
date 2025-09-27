using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video videoSetOne = new Video();
        Video videoSetTwo = new Video();
        Video videoSetThree = new Video();

        string videoTitleOne = "Shampoo Product Review";
        string videoAuthorOne = "Kelsey Hansel";
        int videoLengthOne = 450;
        string videoTitleTwo = "Conditioner Product Review";
        string videoAuthorTwo = "Kelsey Hansel";
        int videoLengthTwo = 498;

        string videoTitleThree = "Body Wash Product Review";
        string videoAuthorThree = "Kelsey Hansel";
        int videoLengthThree = 546;

        videoSetOne.SetVideoContent(videoTitleOne, videoAuthorOne, videoLengthOne);
        videoSetOne.AddComments("Tadhg Ngo", "The shampoo looks like it works really well!");
        videoSetOne.AddComments("Gayathri Esposito", "What are the other scents they have for their shampoo?");
        videoSetOne.AddComments("Aristeus Sharma", "I like that you listed all the ingredients.");
        videoSetOne.AddComments("Mariya MacGowan", "I'm going to buy this shampoo right now!");
        videos.Add(videoSetOne);
        videoSetTwo.SetVideoContent(videoTitleTwo, videoAuthorTwo, videoLengthTwo);
        videoSetTwo.AddComments("Mads Devi", "I like that it made your hair look soft to the touch.");
        videoSetTwo.AddComments("Miray Chester", "Does this work for all hair types? I have curly hair but would be interested in trying this.");
        videoSetTwo.AddComments("Penélope Julien", "I love the smell of pomegranate! Added to cart!");
        videos.Add(videoSetTwo);
        videoSetThree.SetVideoContent(videoTitleThree, videoAuthorThree, videoLengthThree);
        videoSetThree.AddComments("Radulf Petersen", "Does it work for both men and women?");
        videoSetThree.AddComments("Bedivere Bourgeois", "How strong is the scent after rinsing?");
        videoSetThree.AddComments("Kaarel Arlotti", "I love that it also moisturizes the skin.");
        videoSetThree.AddComments("Makena Metaxas", "I am glad that it is hypoallergenic. I tend to break out when trying new products.");
        videos.Add(videoSetThree);

        foreach (Video video in videos)
        {
            video.DisplayVideoContent();
        }
    }
}