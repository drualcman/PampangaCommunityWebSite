using PampangaCommunityWebSite.Client.Entities;

namespace PampangaCommunityWebSite.Client.Pages;
public partial class AboutUs
{
    List<MemberProfile> MemberProfiles = 
        [
            new MemberProfile
            {
                Name = "Angel",
                PictureUrl = "https://scontent.fcrk1-5.fna.fbcdn.net/v/t39.30808-6/368486452_6504349782993600_5930708710085857527_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeH9-L3FPGepRGEOpgiNA5lzeF4MvYh76ed4Xgy9iHvp55nQb281oFal3u1PtFAYa5E&_nc_ohc=k6njC4ugbSEAX_1mOHN&_nc_ht=scontent.fcrk1-5.fna&oh=00_AfAxudS1rzLTVG89j4SCib6y2VXxNzCZB4YKjd8Nn1C0Tg&oe=65F63BF0"
            },
            new MemberProfile
            {
                Name = "Niel",
                PictureUrl = "https://scontent.fcrk1-1.fna.fbcdn.net/v/t39.30808-6/339742001_773319880683311_5860805105752919765_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeGMo7G5lq-64KCaZZQEoZN7bRr-c6rdjrRtGv5zqt2OtHMNnZxHiMVETMWNxWQb-wk&_nc_ohc=9OMCVmS0-JAAX_-DyVP&_nc_ht=scontent.fcrk1-1.fna&oh=00_AfAvuKRZnoYZyk9tAnAPRL2OW7VbxqSxtaKwKWXtfGulTw&oe=65F7171C"
            } ,
            new MemberProfile
            {
                Name = "Lee",
                PictureUrl = "https://scontent.fcrk1-3.fna.fbcdn.net/v/t1.6435-9/106670389_10215417633828208_4923225981893817160_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeFnrrQn2HylTmLb0DcuNlG8s10AX5Q64y2zXQBflDrjLahlPY-JggAQjjNuMbEJp3o&_nc_ohc=ezIUWniZF8EAX9bUqNw&_nc_ht=scontent.fcrk1-3.fna&oh=00_AfCPiqRmz1GlY-7Ry3EYGFgkU13f5L4rz0yh3S7EKNm5XA&oe=6618D860"
            },
            new MemberProfile
            {
                Name = "Daryl",
                PictureUrl = "https://scontent.fcrk1-5.fna.fbcdn.net/v/t39.30808-6/319749025_701155564757635_2107892020797200196_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeEPzArM4MyMAVi4Z2eDnCv4lfa8SqulQgSV9rxKq6VCBI8yr_HFJdtQeh5BwtghNnY&_nc_ohc=1w5EgFWsImEAX_GBv4k&_nc_ht=scontent.fcrk1-5.fna&oh=00_AfDP-UzbyCRbGmIWUAR_cB_ymZXkljrfD4Hd71f4CXm8zg&oe=65F61587"
            },
            new MemberProfile
            {
                Name = "Angel",
                PictureUrl = "https://scontent.fcrk1-5.fna.fbcdn.net/v/t39.30808-6/368486452_6504349782993600_5930708710085857527_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeH9-L3FPGepRGEOpgiNA5lzeF4MvYh76ed4Xgy9iHvp55nQb281oFal3u1PtFAYa5E&_nc_ohc=k6njC4ugbSEAX_1mOHN&_nc_ht=scontent.fcrk1-5.fna&oh=00_AfAxudS1rzLTVG89j4SCib6y2VXxNzCZB4YKjd8Nn1C0Tg&oe=65F63BF0"
            },
            new MemberProfile
            {
                Name = "Niel",
                PictureUrl = "https://scontent.fcrk1-1.fna.fbcdn.net/v/t39.30808-6/339742001_773319880683311_5860805105752919765_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeGMo7G5lq-64KCaZZQEoZN7bRr-c6rdjrRtGv5zqt2OtHMNnZxHiMVETMWNxWQb-wk&_nc_ohc=9OMCVmS0-JAAX_-DyVP&_nc_ht=scontent.fcrk1-1.fna&oh=00_AfAvuKRZnoYZyk9tAnAPRL2OW7VbxqSxtaKwKWXtfGulTw&oe=65F7171C"
            } ,
            new MemberProfile
            {
                Name = "Lee",
                PictureUrl = "https://scontent.fcrk1-3.fna.fbcdn.net/v/t1.6435-9/106670389_10215417633828208_4923225981893817160_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeFnrrQn2HylTmLb0DcuNlG8s10AX5Q64y2zXQBflDrjLahlPY-JggAQjjNuMbEJp3o&_nc_ohc=ezIUWniZF8EAX9bUqNw&_nc_ht=scontent.fcrk1-3.fna&oh=00_AfCPiqRmz1GlY-7Ry3EYGFgkU13f5L4rz0yh3S7EKNm5XA&oe=6618D860"
            },
            new MemberProfile
            {
                Name = "Daryl",
                PictureUrl = "https://scontent.fcrk1-5.fna.fbcdn.net/v/t39.30808-6/319749025_701155564757635_2107892020797200196_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeEPzArM4MyMAVi4Z2eDnCv4lfa8SqulQgSV9rxKq6VCBI8yr_HFJdtQeh5BwtghNnY&_nc_ohc=1w5EgFWsImEAX_GBv4k&_nc_ht=scontent.fcrk1-5.fna&oh=00_AfDP-UzbyCRbGmIWUAR_cB_ymZXkljrfD4Hd71f4CXm8zg&oe=65F61587"
            }
        ];
}