using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_algo_lib_cs;
using ce100_hw2_algo_lib_test;


namespace ce100_hw2_algo_lib_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MatrixMulRecTest1()
        {
            int row1 = 2, col1 = 2,
           row2 = 2, col2 = 2;
            int[,] A = {{5, 8},
                       {2, 9} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{7 ,3},
                        {6, 4} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 83, 47 },
                              { 68, 42 } };

            Class1.multiplayMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }


        [TestMethod]
        public void MatrixMulRecTest2()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{1, 4},
                       {5, 3} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{2, 7},
                       {6, 2} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 26, 15 },
                              { 28, 41 } };

            Class1.multiplayMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulRecTest3()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{5, 8},
                       {2, 9} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{7 ,3},
                        {6, 4} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 83, 47 },
                              { 68, 42 } };

            Class1.multiplayMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulStrTest1()
        {
            float[,] array = { { 4, 3 },
                           { 1, 5 } };
            float n = 2;

            float[,] array2 = { { 6, 2 },
                            { 7, 0 } };

            float[,] result = { { 45, 8 },
                            { 41, 2 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest2()
        {
            float[,] array = { { 5, 1 },
                           { 2, 4 } };
            float n = 2;

            float[,] array2 = { { 3, 4 },
                            { 2, 1 } };

            float[,] result = { { 17, 21 },
                            { 14, 12 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest3()
        {
            float[,] array = { { 5, 3 },
                           { 9, 6 } };
            float n = 2;

            float[,] array2 = { { 1, 0 },
                            { 5, 7 } };

            float[,] result = { { 20, 21 },
                            { 39, 42 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulItrTest1()
        {
            int[,] A = {{ 1, 2, 3, 4 },
                         { 5, 6, 7, 8 },
                         { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 }};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 },
                         { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 }};

            int[,] C = new int[N, N];

            int[,] expected = { { 34,44,54,64 },
                                { 82,108,134,160},
                                { 34,44,54,64 },
                                { 82,108,134,160} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulItrTest2()
        {
            int[,] A = {{ 10,11,12,13},
                         { 13,14,15,16},
                         { 16,17,18,19},
                         { 20,21,22,23} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { { 10,11,12,13},
                         { 13,14,15,16},
                         { 16,17,18,19},
                         {20,21,22,23 } };

            int[,] C = new int[N, N];

            int[,] expected = { { 695,741,787,833 },
                                { 872,930,988,1046},
                                { 1049,1119,1189,1259 },
                                { 1285,1371,1457,1543} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);

        }

        [TestMethod]
        public void MatrixMulItrTest3()
        {
            int[,] A = {{ 1, 1, 1, 1 },
                         { 2, 2, 2, 2 },
                         { 3, 3, 3, 3 },
                         { 4, 4, 4, 4 }};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { {1, 1, 1, 1 },
                         { 2, 2, 2, 2 },
                         { 3, 3, 3, 3 },
                         { 4, 4, 4, 4 }};

            int[,] C = new int[N, N];

            int[,] expected = { { 10,10,10,10 },
                                { 20,20,20,20},
                                { 30,30,30,30},
                                { 40,40,40,40} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void QuickSoLoTest1()
        {
            int[] array = { 43, 65, 75, 44, 92, 18, 21 };
            int n = array.Length - 1;
            int[] expected = { 18, 21, 43, 44, 65, 75, 92 };

            Class1.quickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest2()
        {
            int[] array = { 43, 65, 75, 44, 92, 18, 21 };
            int n = array.Length - 1;
            int[] expected = { 18, 21, 43, 44, 65, 75, 92 };

            Class1.quickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoLoTest3()
        {
            int[] array = { 435, 651, 981, 143, 762, 205, 501 };
            int n = array.Length - 1;
            int[] expected = { 143, 205, 435, 501, 651, 762, 981 };

            Class1.quickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void QuickSoHoTest1()
        {
            int[] array = { 52, 32, 10, 84, 67, 93, 21 };
            int n = array.Length - 1;
            int[] expected = { 10, 21, 32, 52, 67, 84, 93 };

            Class1.quickSortHoares(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest2()
        {
            int[] array = { 52, 32, 10, 84, 67, 93, 21 };
            int n = array.Length - 1;
            int[] expected = { 10, 21, 32, 52, 67, 84, 93 };

            Class1.quickSortHoares(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSoHoTest3()
        {
            int[] array = { 542, 367, 119, 873, 681, 965, 276 };
            int n = array.Length - 1;
            int[] expected = { 119, 276, 367, 542, 681, 873, 965 };

            Class1.quickSortHoares(array, 0, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest1()
        {
            int[] array = { 8, 4, 2, 6, 9, 0, 1 };
            int n = array.Length - 1;
            int[] expected = { 0, 1, 2, 4, 6, 8, 9 };

            Class1.randomQuickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest2()
        {
            int[] array = { 54, 32, 87, 21, 44, 94, 18 };
            int n = array.Length - 1;
            int[] expected = { 18, 21, 32, 44, 54, 87, 94 };

            Class1.randomQuickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoLoTest3()
        {
            int[] array = { 487, 134, 792, 376, 931, 685, 201 };
            int n = array.Length - 1;
            int[] expected = { 134, 201, 376, 487, 685, 792, 931 };

            Class1.randomQuickSortLomuto(array, 0, n);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest1()
        {
            int[] array = { 43, 82, 17, 98, 54, 73, 26 };
            int n = array.Length;
            int[] expected = { 17, 26, 43, 54, 73, 82, 98 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest2()
        {
            int[] array = { 43, 82, 17, 98, 54, 73, 26 };
            int n = array.Length;
            int[] expected = { 17, 26, 43, 54, 73, 82, 98 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void RandomizedQuickSoHoTest3()
        {
            int[] array = { 365, 612, 489, 153, 952, 556, 763, 295 };
            int n = array.Length;
            int[] expected = { 153, 295, 365, 489, 556, 612, 763, 952 };

            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void SelectionProblemTest1()
        {
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int n = arr.Length, k = 3;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void SelectionProblemTest2()
        {
            int[] arr = { 41, 32, 84, 12, 25, 65 };
            int n = arr.Length, k = 2;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(25, result);
        }


        [TestMethod]
        public void SelectionProblemTest3()
        {
            int[] arr = { 254, 433, 842, 742, 965, 821, 539 };
            int n = arr.Length, k = 7;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(965, result);
        }

        [TestMethod]
        public void HeapSoTest1()
        {
            int[] array = new int[] { 104, 98, 15, 49, 20 };
            int n = array.Length;
            int[] expected = new int[] { 15, 20, 49, 98, 104 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest2()
        {
            int[] array = new int[] { 104, 98, 15, 49, 20 };
            int n = array.Length;
            int[] expected = new int[] { 15, 20, 49, 98, 104 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSoTest3()
        {
            int[] array = new int[] { 348, 546, 781, 233, 460, 904 };
            int n = array.Length;
            int[] expected = new int[] { 233, 348, 460, 546, 781, 904 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest1()
        {
            int[] arr = new int[] { 10, 30, 70, 60, 40, };
            Class1.insert(70);
            Class1.insert(60);
            Class1.insert(40);
            Class1.insert(30);
            Class1.insert(10);
            int expected = Class1.extractMax();
            Assert.AreEqual(70, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest2()
        {
            int[] arr = new int[] { 12, 48, 64, 77, 22 };
            Class1.insert(77);
            Class1.insert(64);
            Class1.insert(48);
            Class1.insert(22);
            Class1.insert(12);
            int expected = Class1.extractMax();
            Assert.AreEqual(77, expected);
        }

        [TestMethod]
        public void PriotyQueueWithHeapTest3()
        {
            int[] arr = new int[] { 852, 538, 632, 74, 1953 };
            Class1.insert(1953);
            Class1.insert(852);
            Class1.insert(632);
            Class1.insert(538);
            Class1.insert(74);
            int expected = Class1.extractMax();
            Assert.AreEqual(1953, expected);
        }


        [TestMethod]
        public void CountingSoTest1()
        {
            int[] array = { 23, 54, 19, 65, 97, 71 };
            int n = array.Length;
            int[] expected = new int[] { 19, 23, 54, 65, 71, 97 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest2()
        {
            int[] array = { 23, 54, 19, 65, 97, 71 };
            int n = array.Length;
            int[] expected = new int[] { 19, 23, 54, 65, 71, 97 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSoTest3()
        {
            int[] array = { 5, 2, 8, 0, 1, 9, 4 };
            int n = array.Length;
            int[] expected = { 0, 1, 2, 4, 5, 8, 9 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSoTest1()
        {
            int[] array = { 12, 34, 56, 94, 87, 23 };
            int n = array.Length;
            int[] expected = { 12, 23, 34, 56, 87, 94 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);

        }

        [TestMethod]
        public void RadixoTest2()
        {
            int[] array = { 12, 34, 56, 94, 87, 23 };
            int n = array.Length;
            int[] expected = { 12, 23, 34, 56, 87, 94 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSoTest3()
        {
            int[] array = { 486, 943, 154, 762, 204 };
            int n = array.Length;
            int[] expected = { 154, 204, 486, 762, 943 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }


    }
}