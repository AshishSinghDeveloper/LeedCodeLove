using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class FloodFill
    {
        public static int[][] FloodFilling(int[][] image, int sr, int sc, int color)
        {

            if (image[sr][sc] == color) return image;
            int existingColor = image[sr][sc];
            Console.WriteLine($"existingColor: {existingColor}");

            int xLen = image.Length;
            int yLen = image[xLen - 1].Length;

            Console.WriteLine($"xLen: {xLen}, yLen:{yLen}");



            return Recursion(image, sr, sc, color, xLen, yLen, existingColor);
        }

        private static int[][] Recursion(int[][] image, int sr, int sc, int color, int xLen, int yLen, int existingColor)
        {

            Console.WriteLine($"sr: {sr}, sc: {sc}");
            if (image[sr][sc] == color)
                return image;

            image[sr][sc] = color;

            // Right
            if (sr + 1 < xLen && image[sr + 1][sc] == existingColor)
                Recursion(image, sr + 1, sc, color, xLen, yLen, existingColor);
            // Left
            if (sr - 1 >= 0 && image[sr - 1][sc] == existingColor)
                Recursion(image, sr - 1, sc, color, xLen, yLen, existingColor);
            // Up
            if (sc + 1 < yLen && image[sr][sc + 1] == existingColor)
                Recursion(image, sr, sc + 1, color, xLen, yLen, existingColor);
            // Down
            if (sc - 1 >= 0 && image[sr][sc - 1] == existingColor)
                Recursion(image, sr, sc - 1, color, xLen, yLen, existingColor);

            return image;
        }
    }
}
