int[] arr = { 5, 4, 7, 2, 9 };
 
        int[] copy = new int[arr.Length];
        arr.CopyTo(copy, 0);
 
        Console.WriteLine(String.Join(", ", copy));