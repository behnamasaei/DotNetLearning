

namespace Collections;
public class Array
{
    public void Main()
    {
        /// single-dimensional array
        /// 
        int[] arrayOne = new int[5];
        arrayOne[0] = 1;

        int[] arrayTwo = { 1, 2, 3, 4, 5 };
        int[] arrayThree = new int[] { 1, 2, 3, 4, 5 };


        /// Multidimensional Arrays
        /// 
        int[,] MArrayOne;
        int[,] MArrayTwo = new int[,] { { 1, 2, }, { 2, 3, } };



        ///Jagged Arrays
        ///
        int[][] JArrayOne = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };


        Message(new string[] { "Hello", "World!" });
        // output:
        // Hello
        // World!


        /// Param Arrays (method)
        /// 
        void Message(params string[] texts)
        {
            foreach (var text in texts)
            {
                Console.WriteLine(text);
            }
        }
    }


   
    

}

