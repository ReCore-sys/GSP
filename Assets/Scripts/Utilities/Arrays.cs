using System;

namespace Utils
{
    public abstract class Arrays
    {
        /// <summary>
        /// Takes an array and will return an array of chunks of the array
        /// </summary>
        /// <param name="Array">The array to split up</param>
        /// <param name="ChunkSize">The size of each chunk</param>
        /// <returns>An array of arrays with size <paramref name="ChunkSize"/></returns>
        public static string[][] ChunkArray(string[] Array, int ChunkSize)
        {
            if (Array.Length <= ChunkSize)
            {
                return new[] { Array };
            }
            int ArrayLength = Array.Length;
            int ChunkCount = (ArrayLength + ChunkSize - 1) / ChunkSize;
            string[][] Result = new string[ChunkCount][];
            for (int I = 0; I < ChunkCount; I++)
            {
                int Start = I * ChunkSize;
                int Length = Math.Min(ChunkSize, ArrayLength - Start);
                string[] Temp = new string[Length];
                System.Array.Copy(Array, Start, Temp, 0, Length);
                Result[I] = Temp;
            }

            return Result;
        }
    }
}