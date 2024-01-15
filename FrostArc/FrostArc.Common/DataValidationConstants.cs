using System.Xml.Linq;

namespace FrostArc.Common
{
    public static class DataValidationConstants
    {
        public static class ApplicationUser
        {
            public const int DisplayNameMaxLength = 50;

            public const int ProfilePictureMaxLength = 2048;
        }

        public static class Comment
        {
            public const int ContentMaxLength = 1500;
        }

        public static class Community
        {
            public const int NameMaxLength = 25;

            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMaxLength = 2048;
        }

        public static class Developer
        {
            public const int NameMaxLength = 50;

            public const int DescriptionMaxLength = 2000;
        }

        public static class Game
        {
            public const int TitleMaxLength = 100;

            public const int DescriptionMaxLength = 2000;

            public const int ImageUrlMaxLength = 2048;
        }

        public static class Genre
        {
            public const int NameMaxLength = 100;

            public const int DescriptionMaxLength = 500;
        }

        public static class Platform
        {
            public const int NameMaxLength = 50;

            public const int DescriptionMaxLength = 500;
        }

        public static class Post
        {
            public const int TitleMaxLength = 250;

            public const int ContentMaxLength = 5000;

            public const int ImageUrlMaxLength = 2048;

            public const double LikesMaxValue = double.MaxValue;

            public const double LikesMinValue = 0;

            public const double DislikesMaxValue = double.MaxValue;

            public const double DislikesMinValue = 0;
        }
    }
}
