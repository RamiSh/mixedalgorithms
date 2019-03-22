using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Numerics;
using ConsoleApp1.BST;
using ConsoleApp1.Func;
using Datastructures;

namespace ConsoleApp1
{
    class Program
    {
        public Program()
        {

        }
        public int MyProperty { get; set; }
        static List<int>[] x;
        public int Tubl { get; set; }
        public class Contact
        {
            public string Id { get; set; }
            public List<string> Emails { get; set; }
        }

        public static string BalanceString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            // asd()sd)

            return input;
        }

        public static List<Contact> Filter(List<Contact> contacts)
        {
            var isDuplicate = false;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (isDuplicate)
                {
                    contacts.RemoveAt(--i);
                    isDuplicate = false;
                }
                for (int j = i + 1; j < contacts.Count; j++)
                {
                    if (contacts[j].Emails.Intersect(contacts[i].Emails).Any())
                    {
                        contacts.RemoveAt(j);
                        isDuplicate = true;
                        j--;
                    }
                }
            }

            if (isDuplicate)
            {
                contacts.Remove(contacts.Last());
            }

            return contacts;
        }

        public static char GetFirstUniqueChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return ' ';
            }

            Dictionary<char,int> dic = new Dictionary<char, int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i]))
                {
                    dic[input[i]]++;
                }
                else
                {
                    dic.Add(input[i], 1);
                }
            }


            return ' ';
        }
        public static Tuple<int, int> FindTwoSum(List<int> numbers, int sum)
        {
            var remanders = new HashSet<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var n = numbers[i];

                if (remanders.Contains(n))
                {
                    return new Tuple<int, int>(n, sum - n);
                }
                else
                {
                    remanders.Add(sum - n);
                }
            }

            return null;
        }
        public static void getRepeatedWordsCount(string sentence)
        {
            var words = sentence.Split(' ').ToList();

            HashSet<string> set = new HashSet<string>();

            words.ForEach(w =>
            set.Add(w));

        }

        public static TTo Convert<TFrom, TTo>(Func<TFrom, TTo> convertor, TFrom objectToConvert)
        {
            return convertor(objectToConvert);
        }


        static void Main1(string[] args)
        {
            //Class1 c = new Class1
            //{
            //    Prop1 = 1,
            //    Prop2 = 2
            //};

            //Class2 c2 = new Class2();

            //Convert((c1) =>
            //{
            //    return new Class2
            //    {
            //        Name1 = c1.Prop1.ToString(),
            //        Name2 = c1.Prop2.ToString()
            //    };
            //}, c);

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //            Console.WriteLine("Hello World!");

            //            List<string> x = new List<string>
            //            {
            //"{}[]()",
            //"{[}]}"            };


            //            List<int> xx = new List<int>()
            //            {
            //                256741038, 623958417, 467905213, 714532089, 938071625
            //            };

            //            miniMaxSum(xx.ToArray());

            //var startingLines = GetPossibleMovingLines(new Point(1, 1), 5);
            //var totalHitPoints = startingLines.Sum(l => l.HitPoints);

            // var x = GetFibonacci(1000);

            //var input = new List<int> { 0, 5, 1, 6, 9, 15, 11, 1,12,13,1 };
            //var x = getSumPairs(input, 25);

            //        var contacts = new List<Contact>{
            //  new Contact {Id = "1",Emails = new List<string>{"r@gmail", "a@gmail"}},
            //  new Contact {Id = "2",Emails = new List<string>{"r@gmail"}},
            //  new Contact {Id = "3",Emails = new List<string>{"r@gmail"}},
            //  new Contact {Id = "4",Emails = new List<string>{"y@gmail"}},
            //  new Contact {Id = "5",Emails = new List<string>{"x@gmail"}},
            //  new Contact {Id = "6",Emails = new List<string>{"a@gmail"}},
            //  new Contact {Id = "7",Emails = new List<string>{"z@gmail"}},
            //  new Contact {Id = "8",Emails = new List<string>{"z@gmail"}}
            //};

            //        contacts = Filter(contacts);
            //        Console.WriteLine(contacts.Count);

            //var bst = new BinarySearchTree();
            //bst.Insert(10);
            //bst.Insert(15);
            //bst.Insert(8);
            //bst.Insert(19);
            //bst.Insert(2);
            //bst.Insert(1);
            //bst.Insert(3);
            //InorderTraversal(bst.Root);
            //FindAKeyInBST(bst.Root, 1);

            //var visitedNodes = bst.BreadthFirstTraversal();

            //visitedNodes.ForEach(n => Console.WriteLine($@"Node value: {n.Value}, Node Level: {n.Level}"));

            //getRepeatedWordsCount("rami will get a beautiful wife inshallah rami is a good man");

            //FindTwoSum(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 18);

            //w(findSumToZeroSubArray(new List<int> { 1, 1, 5, 6, -11 }));

            //var x = mergeTwoLists(new List<int> { 0, 2, 0, 0, 3, 0, 4, 10 }, new List<int> { -5, 1, 5, 75 });

            //var x = nextClosestTime("19:35");

            //var res = new List<int>();
            //  permutationsWithRepeatedDigits(new List<int> { 1,9,3,5 }, "", 0, ref res);

            //var s = LicenseKeyFormatting("5F3Z-2e-9-w", 4);

            //var l = LengthOfLongestSubstringTwoDistinct("eceba");
            //x.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine(71 >> 1);

            //var res =
            //    CalcEquation(new string[,] { { "x1", "x2" }, { "x2", "x3" }, { "x3", "x4" }, { "x4", "x5" } },
            //    new double[] { 3.0, 4.0, 5.0, 6.0 },
            //new string[,] { { "x1", "x5" }, { "x5", "x2" }, { "x2", "x4" }, { "x2", "x2" }, { "x2", "x9" }, { "x9", "x9" } });

            //Graph.Graph g = new Graph.Graph(5);
            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(1, 2);
            //g.AddEdge(1, 3);
            //g.AddEdge(1, 0);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 4);
            //g.AddEdge(2, 1);
            //g.AddEdge(3,1);
            //g.FindAllBidirectVertices(g.Vertices[0]);

            //var toBeSorted = new List<int> { 1, 100, 9, 3, 5, 11, 9, 10, -5, 18, -4, 20 };
            //Sort.MergeSort.Sort(toBeSorted); 
            //var l = new LinkedList.DoublyLinkedList<int>(5);

            //l.Insert(6);
            //l.Insert(7);
            //l.Insert(8);

            //var res = TwoListsDiff(new List<int> { 1, 100, 9, 3, 5, 11, 9, 10, -5, 18, -4, 20 },
            //    new List<int> { 2, 3, 4, 5, 6, 6, 6, 6, 6 });

            var array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 1, 1, 1, 1, 1, 1 };
            //var res = MinimumNumberOfSwapsToSortArray(array);

            //var res = FindZeroToReplace(new List<int> { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, });

            //var res = FindMaxProductOfTwoInts(new List<int> { -100, -200, 1, 2, 100, 3, 5, 11, 9, 10, -5, 18, -4, 20 });
            //var res = ShuffleArray(array);
            //var res = RearrangeArray(array);

            //var res = FindEquilibrium(array);
            //var res = MajorityNumber(array);
            //var x = SolveTheQueenCaller(8);
            //var parents = FindShortedPathInMaze(new Location { Row = 2, Column = 4 });
            //var shortestPath = GetPathFromParents(parents, new Location { Row = 0, Column = 0 }, new Location { Row = 2, Column = 4 });
            //var res = FindLongestConnectedColor();
            //var res = CollectFruitV2(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
            //var res = ValidParentheses("([)]");
            //var x = LicenseKeyFormatting("5F3Z-2e-9-w", 4);
            //BackspaceCompare("a##c", "#a#c");

            //var ms = new MinStack();
            //ms.Push(0);
            //ms.Push(1);
            //ms.Push(-1);
            //ms.Pop();
            //ms.Pop();
            //ms.Pop();
            //var r = ms.GetMin();

            //var res = FirstUniqChar("loveleetcode");
            //var res = TwoSum(new int[] { 2,2,0, 11, 15,7,7 }, 9);
            //var res = LengthOfLongestSubstring("pwwkew");
            //var res = Reverse(1999999999);

            //var res = RepeatedStringMatch("aabaaabaaac", "aabaaac");
            int[,] m = {
                                {1, 2, 3},
                                {4,5,6},
                                {7,8,9}
                            };
            //var res = SpiralOrder(m);
            //var res = PlusOne(new int[] { 9, 2, 3, 9 });

            //var res = LengthOfLongestSubstringKDistinct("ababffzzeee", 3);
            // var res = ReverseWords("rami    is going to have a happy and successful    life");

            //doSomething(a => (a + a).ToString());

          

            Console.ReadKey();
        }

        Func<int, string> ConvertIntToString;

        public static void doSomething(Func<int, string> convertor)
        {
            Console.WriteLine(convertor(1));
        }

        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            s = s.Trim();

            var reversedWords = new StringBuilder();
            var insertAt = 0;
            var spaceAdded = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (!spaceAdded)
                    {
                        reversedWords.Append(s[i]);
                        insertAt = reversedWords.Length;
                        spaceAdded = true;
                    }
                }
                else
                {
                    spaceAdded = false;
                    reversedWords.Insert(insertAt, s[i]);
                }
            }

            return reversedWords.ToString();
        }

        public static void FindAKeyInBST(Node root, int value)
        {
            if (root == null)
            {
                return;
            }

            if (root.Value == value)
            {
                Console.WriteLine("found it");
            }

            if (value > root.Value)
            {
                if (root.Right != null)
                {
                    FindAKeyInBST(root.Right, value);
                }
                else
                {
                    return;
                }
            }

            if (value < root.Value)
            {
                if (root.Left != null)
                {
                    FindAKeyInBST(root.Left, value);
                }
                else
                {
                    return;
                }
            }

        }
        public static void InorderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            var res = new List<Node>();
            InorderTraversal(root.Left);
            Console.WriteLine(root.Value);
            InorderTraversal(root.Right);

            return;
        }

        public static int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var count = new Dictionary<char, int>();
            var left = 0;
            var longestStreak = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                {
                    count[s[i]]++;
                }
                else
                {
                    count[s[i]] = 1;
                }

                while (count.Count() > k)
                {
                    count[s[left]]--;
                    if (count[s[left]] == 0)
                    {
                        count.Remove(s[left]);
                    }

                    left++;
                }

                longestStreak = Math.Max(longestStreak, i - left + 1);
            }

            return longestStreak;

        }

        public static int Trap(int[] height)
        {
            int start = 0, end = height.Length - 1, maxLeft = 0, maxRight = 0, res = 0;

            while (start <= end)
            {
                maxLeft = Math.Max(maxLeft, height[start]);
                maxRight = Math.Max(maxRight, height[end]);
                if (maxLeft <= maxRight)
                {
                    res += maxLeft - height[start];
                    start++;
                }
                else
                {
                    res += maxRight - height[end];
                    end--;
                }
            }
            return res;
        }

        public static int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0)
            {
                return new int[0];
            }

            if (digits.Length == 1 & digits[0] == 9)
            {
                return new int[2] { 1, 0 };
            }

            if (digits.Length == 1)
            {
                return new int[1] { digits[0] + 1 };
            }

            int resLength = digits.Length + 1;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 9)
                {
                    resLength = digits.Length;
                    break;
                }
            }

            var res = new int[resLength];
            var carryOver = 0;

            var newDigit = digits[digits.Length - 1] + 1;

            if (newDigit == 10)
            {
                carryOver = 1;
                newDigit = 0;
            }

            res[--resLength] = newDigit;

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                newDigit = digits[i] + carryOver;
                carryOver = 0;
                if (newDigit == 10)
                {
                    carryOver = 1;
                    newDigit = 0;
                }
                res[--resLength] = newDigit;
            }

            if (carryOver == 1)
            {
                res[0] = 1;
            }

            return res;
        }

        public static List<int> SpiralOrder(int[,] m)
        {
            if (m.Length == 0)
            {
                return new List<int>();
            }

            var visited = new HashSet<int>();
            var direction = new int[4, 2] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
            var row = 0;
            var col = 0;
            var rowCount = m.GetLength(0);
            var colCount = m.GetLength(1);

            while (visited.Count < m.Length)
            {
                var currentDir = 0;

                while (currentDir < 4)
                {
                    visited.Add(m[row, col]);

                    var newRow = row + direction[currentDir, 0];
                    var newCol = col + direction[currentDir, 1];



                    if (newRow >= rowCount || newRow < 0)
                    {
                        currentDir++;
                        continue;
                    }

                    if (newCol >= colCount || newCol < 0)
                    {
                        currentDir++;
                        continue;
                    }

                    if (visited.Contains(m[newRow, newCol]))
                    {
                        if (visited.Count == m.Length)
                        {
                            break;
                        }
                        currentDir++;

                        continue;
                    }

                    row = newRow;
                    col = newCol;
                }
            }

            return visited.ToList();
        }
        public static int RepeatedStringMatch(string A, string B)
        {

            if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B))
            {
                return -1;
            }

            var biggerA = new StringBuilder(A);

            var times = 1;
            while (biggerA.Length < B.Length)
            {
                times++;
                biggerA.Append(A);
            }
            if (KMPSearch(biggerA.ToString(), B) == -1)
            {
                biggerA.Append(A);
                times++;
                if (KMPSearch(biggerA.ToString(), B) == -1)
                {
                    return -1;
                }
            }

            return times;
        }
        public static int KMPSearch(string s, string pattern)
        {
            int i = 0;
            int j = 0;
            var lpiTbl = GetLPI(pattern);

            while (i < s.Length && j < lpiTbl.Length - 1)
            {
                if (pattern[j] == s[i])
                {
                    j++;
                    i++;
                }
                else
                {
                    if (j > 0)
                    {
                        j = lpiTbl[j];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (j >= lpiTbl.Length - 1)
                return i - j;
            else
                return -1;
        }
        public static int[] GetLPI(string s)
        {
            var lpi = new int[s.Length + 1];
            int runner = 1;
            int j = 0;
            lpi[0] = 0;
            lpi[1] = 0;

            while (runner < s.Length)
            {
                if (s[runner] == s[j])
                {
                    lpi[runner + 1] = j + 1;
                    j++;
                    runner++;
                }
                else
                {
                    if (j > 0)
                    {
                        j = 0;
                    }
                    else
                    {
                        lpi[runner + 1] = 0;
                        runner++;
                    }
                }
            }
            return lpi;
        }

        public static int Reverse(int x)
        {
            int res = 0;
            var isNegative = x < 0 ? true : false;
            if (isNegative)
            {
                x *= -1;
            }

            if (x < 10 && x >= 0)
            {
                return x;
            }

            while (x > 0)
            {
                var newDigit = x % 10;
                res = checked((res * 10) + newDigit);
                x -= newDigit;
                x /= 10;
            }

            return isNegative ? res * -1 : res;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }
            var start = 0;
            var res = 0;
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    start = dic[s[i]] + 1;

                }
                res = Math.Max(i - start + 1, res);
                dic[s[i]] = i;
            }

            return res;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var set = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))
                {
                    return new int[] { set[nums[i]], i };
                }
                else
                {


                    set[target - nums[i]] = i;

                }
            }

            return new int[2];
        }

        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            var dic = new Dictionary<char, int>();
            var set2 = new HashSet<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], i);
                    set2.Add(i);

                }
                else
                {
                    set2.Remove(dic[s[i]]);
                }
            }

            return set2.Count() > 0 ? set2.First() : -1;
        }
        public static bool ValidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.Length == 1)
            {
                return false;
            }


            var openParaStack = new Stack<char>();

            var matchingPara = new Dictionary<char, char>
            {
                { '}', '{' },
                { ')', '(' },
                { ']', '[' }
            };

            var openPara = new HashSet<char> { '(', '{', '[' };

            for (int i = 0; i < s.Length; i++)
            {
                if (openPara.Contains(s[i]))
                {
                    openParaStack.Push(s[i]);

                }
                else
                {
                    if (openParaStack.Count == 0 || matchingPara[s[i]] != openParaStack.Pop())
                    {
                        return false;
                    }

                }
            }

            return openParaStack.Count == 0 ? true : false;
        }
        public static int CollectFruitV2(int[] tree)
        {
            var max = 0;
            var dic = new Dictionary<int, int>();
            var start = 0;

            for (int end = 0; end < tree.Length; end++)
            {
                if (!dic.ContainsKey(tree[end]))
                {
                    dic.Add(tree[end], end);
                }
                else
                {
                    dic[tree[end]] = end;
                }

                if (dic.Count() == 3)
                {
                    var minIndex = dic.Values.Min();
                    dic.Remove(tree[minIndex]);
                    start = minIndex + 1;
                }


                max = Math.Max(end - start + 1, max);
            }

            return max;
        }
        //0,1,6,6,4,4,6
        //3,3,3,1,2,1,1,2,3,3,4
        //0,0,0, 1,6,1, 6, 6, 4, 4, 6
        // 0,2,1,1
        // 1,0,3,4,3
        // 1,1,4,0,4
        public static int CollectFruit(int[] tree)
        {
            if (tree == null || tree.Length == 0)
            {
                return 0;
            }

            if (tree.Length <= 2)
            {
                return tree.Length;
            }

            var maxFruitCollected = 0;
            var baskets = new HashSet<int>();
            baskets.Add(tree[0]);
            baskets.Add(tree[1]);

            var lastIndexOfFirstTree = 0;
            var start = 0;
            var end = 1;

            for (int i = 2; i < tree.Length; i++)
            {
                if (baskets.Count < 2)
                {
                    baskets.Add(tree[i]);
                }

                if (baskets.Contains(tree[i]))
                {
                    if (tree[i] == baskets.First())
                    {
                        lastIndexOfFirstTree = i;
                    }
                    end++;
                }
                else
                {
                    baskets.Remove(tree[start]);

                    maxFruitCollected = Math.Max(maxFruitCollected, (end - start + 1));

                    start = lastIndexOfFirstTree + 1;
                    end = i;
                    lastIndexOfFirstTree = end - 1;

                    baskets.Add(tree[end]);
                }
            }

            maxFruitCollected = Math.Max(maxFruitCollected, (end - start + 1));

            return maxFruitCollected;
        }
        public static string LicenseKeyFormatting(string S, int K)
        {
            var newS = new StringBuilder();
            var runner = 0;
            for (int a = S.Length - 1; a >= 0; a--)
            {
                if (S[a] == '-') continue;

                if (runner == 4)
                {
                    newS.Append('-');
                    runner = 0;
                }

                newS.Append(Char.ToUpper(S[a]));
                runner++;
            }


            return new string(newS.ToString().Reverse().ToArray());
        }

        /// <summary>
        /// Finds the longest connect region per color.
        /// </summary>
        /// <returns>Returns a pair that has the color and the count of the connected cells</returns>
        public static (int color, int count) FindLongestConnectedColor()
        {
            int[,] graph = {
                                {1, 1, 1, 2,2,3},
                                {1, 1, 1, 2,2,3},
                                {1, 1, 1, 2,2,3}
                            };

            var graphRowsCount = graph.GetLength(0);
            var graphColumnsCount = graph.GetLength(1);

            var visited = new bool[graphRowsCount, graphColumnsCount];

            // first int represents the color, second int represents the region cells' count
            var longestRegion = new Tuple<int, int>(-1, -1);


            for (int row = 0; row < graphRowsCount; row++)
            {
                for (int column = 0; column < graphColumnsCount; column++)
                {
                    var color = graph[row, column];

                    if (!visited[row, column])
                    {
                        var length = GetConnectedRegionLength(row, column, graph, visited);

                        if (longestRegion.Item2 < length)
                        {
                            longestRegion = new Tuple<int, int>(color, length);
                        }
                    }
                }
            }

            return (longestRegion.Item1, longestRegion.Item2);
        }

        private static int GetConnectedRegionLength(int row, int column, int[,] graph, bool[,] visited)
        {
            var directionRow = new List<int> { -1, +1, 0, 0 };
            var directionColumn = new List<int> { 0, 0, +1, -1 };

            var connectedCellsCount = 1;

            var color = graph[row, column];

            var openNodes = new Queue<(int row, int column)>();

            openNodes.Enqueue((row, column));
            visited[row, column] = true;

            while (openNodes.Count > 0)
            {
                var node = openNodes.Dequeue();

                for (int a = 0; a < directionRow.Count; a++)
                {
                    var newRow = node.row + directionRow[a];
                    var newColumn = node.column + directionColumn[a];

                    if (newRow < 0 || newColumn < 0) continue;
                    if (newRow >= graph.GetLength(0) || newColumn >= graph.GetLength(1)) continue;
                    if (graph[newRow, newColumn] != color) continue;
                    if (visited[newRow, newColumn]) continue;

                    openNodes.Enqueue((newRow, newColumn));
                    visited[newRow, newColumn] = true;
                    connectedCellsCount++;
                }
            }

            return connectedCellsCount;
        }

        public static bool BackspaceCompare(string S, string T)
        {
            var firstRunner = S.Length - 1;
            var secondRunner = T.Length - 1;
            var t = new StringBuilder(T);
            var s = new StringBuilder(S);

            var NOB = 0;

            while (firstRunner >= 0)
            {
                if (s[firstRunner] == '#')
                {
                    NOB++;
                    s.Remove(firstRunner, 1);
                    firstRunner--;
                    continue;
                }

                if (NOB > 0)
                {
                    s.Remove(firstRunner, 1);
                    NOB--;
                }

                firstRunner--;
            }

            NOB = 0;
            while (secondRunner >= 0)
            {
                if (t[secondRunner] == '#')
                {
                    NOB++;
                    t.Remove(secondRunner--, 1);
                    continue;
                }

                if (NOB > 0)
                {
                    t.Remove(secondRunner, 1);
                    NOB--;
                }

                secondRunner--;
            }

            return string.Equals(s.ToString(), t.ToString());

        }

        public static Dictionary<Location, Location> FindShortedPathInMaze(Location target)
        {
            int[,] matrix = {
                                {1, 0, 1, 1,1},
                                {1, 0, 1, 0,1},
                                {1, 1, 1, 0,1}
                            };
            var rows = 3;
            var columns = 5;

            var queue = new Queue<Location>();
            var visited = new bool[rows, columns];
            var parents = new Dictionary<Location, Location>();

            queue.Enqueue(new Location { Row = 0, Column = 0 });
            visited[0, 0] = true;

            while (queue.Any())
            {
                var currentLocation = queue.Dequeue();

                if (currentLocation.Equals(target))
                {
                    return parents;
                }

                var children = GetLocations(currentLocation.Row, currentLocation.Column, matrix, rows, columns);

                foreach (var c in children)
                {
                    if (visited[c.Row, c.Column]) continue;

                    queue.Enqueue(c);
                    visited[c.Row, c.Column] = true;
                    parents.Add(c, currentLocation);
                }
            }

            return null;
        }


        private static List<Location> GetPathFromParents(Dictionary<Location, Location> parents, Location start, Location end)
        {

            var path = new List<Location>();
            var walker = end;

            while (parents.ContainsKey(walker))
            {
                path.Add(walker);
                walker = parents[walker];
            }

            if (walker.Equals(start))
            {
                path.Add(walker);
                path.Reverse();


                return path;
            }
            return null;
        }
        private static List<Location> GetLocations(int row, int column, int[,] matrix, int rowsCount, int columnsCount)
        {
            var locations = new List<Location>();

            //Top
            if (row - 1 >= 0 && matrix[row - 1, column] == 1)
            {
                locations.Add(new Location { Row = row - 1, Column = column });
            }

            //Bottom
            if (row + 1 < rowsCount && matrix[row + 1, column] == 1)
            {
                locations.Add(new Location { Row = row + 1, Column = column });
            }

            //Right
            if (column + 1 < columnsCount && matrix[row, column + 1] == 1)
            {
                locations.Add(new Location { Row = row, Column = column + 1 });
            }

            //Left
            if (column - 1 >= 0 && matrix[row, column - 1] == 1)
            {
                locations.Add(new Location { Row = row, Column = column - 1 });
            }

            return locations;
        }
        public class Location
        {
            public int Row { get; set; }
            public int Column { get; set; }


            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                var objectAsLocation = obj as Location;

                if (obj == null)
                {
                    return false;
                }

                if (objectAsLocation.Row == Row && objectAsLocation.Column == Column)
                {
                    return true;
                }

                return false;
            }

            public override int GetHashCode()
            {
                return (Row.GetHashCode() * 2) + (Column.GetHashCode() * 2);
            }
        }
        public static bool SolveTheQueenCaller(int n)
        {
            int[,] board = new int[n, n];


            return DFS_SolveTheQueen(board, n, 0);

        }

        private static bool DFS_SolveTheQueen(int[,] board, int n, int c)
        {
            if (c >= n)
            {
                return true;
            }

            //loop through the rows for the current passed in column (c)
            for (int i = 0; i < n; i++)
            {
                if (savePlace(board, n, i, c))
                {
                    board[i, c] = 1;

                    if (DFS_SolveTheQueen(board, n, c + 1))
                    {
                        return true;
                    }

                    board[i, c] = 0;
                }
            }

            return false;
        }

        private static bool savePlace(int[,] board, int n, int r, int c)
        {
            // go (left) straight line
            for (int i = 0; i < c; i++)
            {
                if (board[r, i] == 1)
                {
                    return false;
                }
            }

            // go (left) diagonal up
            for (int i = r - 1, j = c - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            // go (left) diagonal down
            for (int i = r + 1, j = c - 1; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        ////http://www.techiedelight.com/replace-element-array-product-every-element-without-using-division-operator/
        //public static List<int> FindProduct(List<int> a)
        //{
        //    if (a == null)
        //    {
        //        return null;
        //    }

        //    if (a.Count == 1)
        //    {
        //        return a;
        //    }


        //    var products = new Dictionary<int, Tuple<int, int>>();
        //    products.Add(0, new Tuple<int, int>(1, 0));

        //    for (int i = 0; i < a.Count-1; i++)
        //    {
        //        products.Add(i + 1, new Tuple<int, int>(a[i] * products[i].Item1, 0));
        //    }


        //    for (int i = a.Count - 1; i >=1; i--)
        //    {
        //        products[i].Item2 = 
        //    }
        //}

        //solved in 8:19 min
        //url: http://www.techiedelight.com/find-majority-element-in-an-array-boyer-moore-majority-vote-algorithm/
        public static int MajorityNumber(List<int> a)
        {
            if (a == null)
            {
                return -1;
            }

            if (a.Count == 1)
            {
                return a[0];
            }

            var dic = new Dictionary<int, int>();

            for (int i = 0; i < a.Count; i++)
            {
                if (!dic.ContainsKey(a[i]))
                {
                    dic.Add(a[i], 1);
                }
                else
                {
                    dic[a[i]]++;
                    if (dic[a[i]] > a.Count / 2)
                    {
                        return a[i];
                    }
                }
            }

            return -1;
        }
        public static int FindEquilibrium(List<int> a)
        {

            if (a == null || a.Count <= 2)
            {
                return -1;
            }

            var total = 0;
            var totalSoFar = 0;

            for (int i = 1; i < a.Count; i++)
            {
                total += a[i];
            }

            for (int i = 1; i < a.Count; i++)
            {
                if (total - totalSoFar == 0)
                {
                    return i;
                }

                totalSoFar += a[i - 1];
                total -= a[i];

            }

            return -1;
        }
        public static List<int> RearrangeArray(List<int> a)
        {

            if (a == null || a.Count <= 2)
            {
                return a;
            }

            for (int i = 1; i < a.Count; i += 2)
            {
                if (a[i] < a[i - 1])
                {
                    swap(a, i, i - 1);
                }

                if (a[i] < a[i + 1])
                {
                    swap(a, i, i + 1);
                }
            }

            return a;
        }
        public static List<int> ShuffleArray(List<int> a)
        {
            if (a == null || a.Count == 1)
            {
                return a;
            }

            if (a.Count == 2)
            {
                return new List<int> { a[1], a[0] };
            }

            var randomer = new Random();

            for (int i = a.Count - 1; i >= 0; i--)
            {
                var newIndex = randomer.Next(a.Count);
                swap(a, i, newIndex);
            }



            return a;
        }

        private static void swap(List<int> a, int indexA, int indexB)
        {
            var temp = a[indexA];

            a[indexA] = a[indexB];
            a[indexB] = temp;
        }
        public static Tuple<int, int> FindMaxProductOfTwoInts(List<int> a)
        {
            int maxNumber = a[0];
            int secondMaxNumber = a[0];

            int minNumber = a[0];
            int secondMinNumber = a[0];

            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] > maxNumber)
                {
                    secondMaxNumber = maxNumber;
                    maxNumber = Math.Max(a[i], maxNumber);
                }
                else
                {
                    secondMaxNumber = Math.Max(a[i], secondMaxNumber);
                }

                if (a[i] < minNumber)
                {
                    secondMinNumber = minNumber;
                    minNumber = Math.Min(a[i], minNumber);
                }
                else
                {
                    secondMinNumber = Math.Min(a[i], secondMinNumber);
                }
            }

            Tuple<int, int> x = (maxNumber * secondMaxNumber) > (minNumber * secondMinNumber) ? new Tuple<int, int>(maxNumber, secondMaxNumber) :
                new Tuple<int, int>(minNumber, secondMinNumber);

            return x;
        }

        // 1 0 1 1 1 1 0 1 0 1
        public static int FindZeroToReplace(List<int> a)
        {
            var count = 0;
            var previousStartIndex = -1;
            var maxCount = 0;
            var maxIndex = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = i - previousStartIndex;
                    previousStartIndex = i;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxIndex = previousStartIndex;
                }

            }

            return maxIndex;
        }

        public static void Find0ToBeReplaced(List<int> a)
        {
            int startingIndex = 0;
            int temp = 0;
            int maxNumberOf1z = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == 0)
                {
                    temp = i;
                }
                else
                {
                    maxNumberOf1z++;
                }
            }
        }

        public static List<string> MinimumNumberOfSwapsToSortArray(List<int> a)
        {
            var numberOfSwaps = new List<string>();
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < a.Count; i++)
            {
                dic.Add(a[i], i);
            }

            for (int i = 0; i < a.Count; i++)
            {
                var number = i + 1;
                var indexOfNumber = dic[number];
                if (indexOfNumber == i)
                {
                    continue;
                }
                numberOfSwaps.Add($@"{indexOfNumber }:{i}");

                var temp = dic[number];

                // swap values in the dic
                dic[number] = dic[a[i]];
                dic[a[i]] = temp;

                // swap values in the array
                temp = a[i];
                a[i] = number;
                a[indexOfNumber] = temp;
            }

            return numberOfSwaps;
        }

        public static Tuple<List<int>, List<int>> TwoListsDiff(List<int> a, List<int> b)
        {
            var dicA = new Dictionary<int, int>();
            var dicB = new Dictionary<int, int>();

            var resA = new List<int>();
            var resB = new List<int>();

            foreach (var item in a)
            {
                if (!dicA.ContainsKey(item))
                {
                    dicA.Add(item, 0);
                }
                else
                {
                    dicA[item]++;
                }
            }

            foreach (var item in b)
            {
                if (!dicB.ContainsKey(item))
                {
                    dicB.Add(item, 0);
                }
                else
                {
                    dicB[item]++;
                }

                if (!dicA.ContainsKey(item))
                {
                    resB.Add(item);
                }
                else
                {
                    dicA[item]--;
                    if (dicA[item] == 0)
                    {
                        dicA.Remove(item);
                    }
                }
            }

            foreach (var item in a)
            {
                if (!dicB.ContainsKey(item))
                {
                    resA.Add(item);
                }
                else
                {
                    dicB[item]--;
                    if (dicB[item] == 0)
                    {
                        dicB.Remove(item);
                    }
                }
            }

            return new Tuple<List<int>, List<int>>(resA, resB);

        }
        public static List<double> CalcEquation(string[,] equations, double[] values, string[,] queries)
        {
            var dic = new Dictionary<string, int>();
            var index = 0;

            for (int i = 0; i < equations.Length / equations.Rank; i++)
            {
                if (!dic.ContainsKey(equations[i, 0]))
                {
                    dic.Add(equations[i, 0], index++);
                }

                if (!dic.ContainsKey(equations[i, 1]))
                {
                    dic.Add(equations[i, 1], index++);
                }
            }

            double[,] matrix = new double[dic.Count, dic.Count];

            for (int i = 0; i < equations.Length / equations.Rank; i++)
            {
                matrix[dic[equations[i, 0]], dic[equations[i, 1]]] = values[i];
                matrix[dic[equations[i, 1]], dic[equations[i, 0]]] = 1 / values[i];
            }

            var res = new List<double>();
            for (int i = 0; i < queries.Length / queries.Rank; i++)
            {
                if (!dic.ContainsKey(queries[i, 0]) || !dic.ContainsKey(queries[i, 1]))
                {
                    res.Add(-1);
                    continue;
                }

                var start = dic[queries[i, 0]];
                var end = dic[queries[i, 1]];

                if (start == end)
                {
                    res.Add(1);
                    continue;
                }


                res.Add(CalcEquationDFS(matrix, start, end, new HashSet<int>(), 1.0F));
            }

            return res;
        }

        public static double CalcEquationDFS(double[,] m, int row, int column, HashSet<int> visited, double res)
        {
            if (visited.Contains(row))
            {
                return 0;
            }

            if (m[row, column] != 0)
            {
                return m[row, column];
            }

            visited.Add(row);
            double temp = 0.0;

            for (int i = 0; i < m.GetLength(1); i++)
            {
                if (m[row, i] != 0)
                {
                    temp = CalcEquationDFS(m, i, column, visited, res * m[row, i]);
                }

                if (temp != 0.0)
                    break;
            }

            visited.Remove(row);

            return temp;
        }



        static int diff = int.MaxValue;
        static string result = "";


        public static int LengthOfLongestSubstringTwoDistinct(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }

            var set = new HashSet<char>();
            var maxLength = 0;
            var backtrackTo = 0;
            var start = 0;
            var captureBacktrack = true;

            for (int i = 0; i < s.Length; i++)
            {
                set.Add(s[i]);

                if (set.Count() > 1 && captureBacktrack)
                {
                    backtrackTo = i;
                    captureBacktrack = false;
                }

                if (set.Count() > 2)
                {
                    if (maxLength < (i - start))
                    {
                        maxLength = i - start;
                    }

                    start = i = backtrackTo;
                    captureBacktrack = true;
                    set.Clear();
                }
            }

            if (set.Count() == 2)
            {
                if (maxLength < (s.Length - start))
                {
                    maxLength = s.Length - start;
                }
            }

            return maxLength;
        }


        public static string nextClosestTime(string time)
        {
            var set = new HashSet<int>();
            set.Add(int.Parse(time[0].ToString()));
            set.Add(int.Parse(time[1].ToString()));
            set.Add(int.Parse(time[3].ToString()));
            set.Add(int.Parse(time[4].ToString()));

            if (set.Count() == 1) return time;

            List<int> digits = new List<int>(set);
            int minute = int.Parse(time.Substring(0, 2)) * 60 + int.Parse(time.Substring(3, 2));

            dfs(digits, "", 0, minute);

            return result;
        }

        public static void permutationsWithRepeatedDigits(List<int> digits, string current, int position, ref List<int> results)
        {
            if (position == 4)
            {
                results.Add(int.Parse(current));
                return;
            }

            for (int i = 0; i < digits.Count(); i++)
            {
                permutationsWithRepeatedDigits(digits, current + digits[i], position + 1, ref results);
            }
        }
        private static void dfs(List<int> digits, string cur, int pos, int target)
        {
            if (pos == 4)
            {
                int m = int.Parse(cur.Substring(0, 2)) * 60 + int.Parse(cur.Substring(2, 2));
                if (m == target) return;
                int d = m - target > 0 ? m - target : 1440 + m - target;
                if (d < diff)
                {
                    diff = d;
                    result = cur.Substring(0, 2) + ":" + cur.Substring(2, 2);
                }
                return;
            }

            for (int i = 0; i < digits.Count(); i++)
            {
                if (pos == 0 && digits[i] > 2) continue;
                if (pos == 1 && int.Parse(cur) * 10 + digits[i] > 23) continue;
                if (pos == 2 && digits[i] > 5) continue;
                if (pos == 3 && int.Parse(cur.Substring(2)) * 10 + digits[i] > 59) continue;
                dfs(digits, cur + digits[i], pos + 1, target);
            }
        }
        public static List<int> mergeTwoLists(List<int> a, List<int> b)
        {
            int mover = a.Count - 1;
            for (int i = a.Count - 1; i >= 0; i--)
            {
                if (a[i] != 0)
                {
                    a[mover--] = a[i];
                }
            }

            var m = mover + 1;
            var n = 0;
            var k = 0;

            while (m < a.Count && n < b.Count)
            {
                if (a[m] < b[n])
                {
                    a[k] = a[m];
                    k++;
                    m++;
                }
                else
                {
                    a[k] = b[n];
                    k++;
                    n++;
                }
            }

            while (n < b.Count)
            {
                a[k++] = b[n++];
            }
            return a;
        }
        public static void w(object o)
        {
            Console.WriteLine(o);
        }
        //Given an array of integers, check if array contains a sub-array having 0 sum.
        // 1 2 3 4 5 6 -11
        public static bool findSumToZeroSubArray(List<int> input)
        {
            var sums = new HashSet<int>();
            var sumSoFar = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var n = input[i];
                sumSoFar += n;

                if (sums.Contains(sumSoFar))
                    return true;

                sums.Add(sumSoFar);// 1 3 
            }

            return false;
        }
        static bool findSum(List<int> input, int target)
        {
            input.Sort();
            int start = 0;
            int sum = 0;
            var iteration = 0;
            for (int i = 0; i < input.Count; i++)
            {
                iteration++;
                sum += input[i];
                while (sum > target)
                {
                    iteration++;
                    sum -= input[start];
                    start++;
                }
                if (sum == target)
                {
                    return true;
                }
            }
            return false;
        }
        //Problem: Given a sequence of nonnegative integers A and an integer T, return whether there is a *continuous sequence* of A that sums up to exactly T
        static List<int> getSumSequence(List<int> input, int target)
        {
            input.Sort();

            var results = new List<int>();
            var runner = -1;
            var foundSomthingInteresting = false;
            var iterations = 0;
            do
            {
                runner++;
                iterations++;
                var currentSum = 0;
                results = new List<int>();

                for (int i = runner; i < input.Count(); i++)
                {
                    iterations++;
                    results.Add(input[i]);
                    currentSum += input[i];
                    if (currentSum == target)
                    {
                        runner = input.Count() - 1;
                        foundSomthingInteresting = true;
                        break;
                    }
                    else if (currentSum > target)
                    {
                        break;
                    }
                }
            }
            while (runner < input.Count() - 1);

            return foundSomthingInteresting ? results : new List<int>();
        }
        static List<Tuple<int, int>> getSumPairs(List<int> input, int target)
        {
            var result = new List<Tuple<int, int>>();

            input.Sort();

            var left = 0;
            var right = input.Count - 1;
            var iterations = 0;
            do
            {
                iterations++;
                var currentSum = input[left] + input[right];
                if (currentSum == target)
                {
                    result.Add(new Tuple<int, int>(input[left], input[right]));
                    right--;
                    continue;
                }

                var notReallyUsed = currentSum > target ? right-- : left++;
            }
            while (left < right);


            return result;
        }
        static List<BigInteger> GetFibonacci(int n)
        {
            var result = new List<BigInteger>(n) { 0, 1 };

            for (int i = 2; i < n; i++)
            {
                result.Add(result[i - 2] + result[i - 1]);
            }

            return result;
        }
        static void superStack(string[] operations)
        {

            Stack<int> simpleStack = new Stack<int>();

            foreach (var operation in operations)
            {
                var details = GetOperationDetails(operation);

                switch (details.Item1)
                {
                    case Operations.Push:
                        simpleStack.Push(details.Item2[0]);
                        break;
                    case Operations.Pop:
                        simpleStack.Pop();
                        break;
                    case Operations.Increment:
                        var container = new List<int>();

                        for (int i = simpleStack.Count; i >= 1; i--)
                        {
                            if (i <= details.Item2[0])
                            {
                                container.Add(simpleStack.Pop() + details.Item2[1]);
                            }
                            else
                            {
                                container.Add(simpleStack.Pop());
                            }
                        }

                        for (int i = container.Count - 1; i >= 0; i--)
                        {
                            simpleStack.Push(container[i]);
                        }
                        break;
                    default:
                        break;
                }

                if (simpleStack.Count == 0)
                {
                    Console.WriteLine("EMPTY");
                }
                else
                {
                    Console.WriteLine(simpleStack.Peek());
                }
            }
        }

        /// <summary>
        /// Returns a tuple that has the operation type and input values
        /// </summary>
        /// <param name="operation">operation string.</param>
        /// <returns>key pair with operation type and input values</returns>
        public static Tuple<Operations, List<int>> GetOperationDetails(string operation)
        {
            operation = operation.ToLower();

            var segments = operation.Split(' ');
            if (operation.Contains("u"))
            {
                return new Tuple<Operations, List<int>>(Operations.Push, new List<int> { int.Parse(segments[1].ToString()) });
            }

            if (operation.Contains("o"))
            {
                return new Tuple<Operations, List<int>>(Operations.Pop, null);
            }

            if (operation.Contains("i"))
            {
                return new Tuple<Operations, List<int>>(Operations.Increment, new List<int> { int.Parse(segments[1].ToString()), int.Parse(segments[2].ToString()) });
            }

            return null;
        }

        public enum Operations
        {
            Push,
            Pop,
            Increment
        }




        static string[] braces(string[] values)
        {
            List<char> openingBraces = new List<char> { '(', '{', '[' };
            List<char> closingBraces = new List<char> { ')', '}', ']' };

            var results = new List<string>();

            foreach (var value in values)
            {
                Stack<char> bracesContainer = new Stack<char>();
                var validString = true;

                for (int i = 0; i < value.Length; i++)
                {

                    if (openingBraces.Contains(value[i]))
                    {
                        bracesContainer.Push(value[i]);
                        continue;
                    }

                    if (closingBraces.Contains(value[i]))
                    {
                        // break if the encountered a closing braces without a previous opening
                        if (bracesContainer.Count == 0)
                        {
                            validString = false;
                            break;
                        }

                        // found a closing brace. remove the opening brace from stack
                        if (value[i] == GetClosingBrace(bracesContainer.Peek()))
                        {
                            bracesContainer.Pop();
                            continue;
                        }
                        else
                        {
                            validString = false;
                            break;
                        }
                    }
                }

                if (bracesContainer.Count == 0 && !validString)
                {
                    results.Add("NO");
                    continue;
                }

                if (bracesContainer.Count == 0 && validString)
                {
                    results.Add("YES");
                    continue;
                }

                if (bracesContainer.Count != 0)
                {
                    results.Add("NO");
                    continue;
                }
            }

            return results.ToArray();

        }

        public static char GetClosingBrace(char openingBrace)
        {
            switch (openingBrace)
            {
                case '(':
                    return ')';
                case '[':
                    return ']';
                case '{':
                    return '}';
                default:
                    return ' ';
            }
        }

        static void miniMaxSum(int[] arr)
        {
            List<int> arrAsList = new List<int>(arr);
            arrAsList.Sort();
            var min = 0;
            var max = 0;
            for (int i = 0; i < arrAsList.Count; i++)
            {
                if (i != 0)
                {
                    max += arrAsList[i];
                }
                if (i < 4)
                {
                    min += arrAsList[i];
                }
            }
            Console.Write($"{min} {max}");

        }

        static void generateMagicSquareLines()
        {
            List<List<int>> lines = new List<List<int>>();
            var iterations = 0;
            for (int a = 1; a < 10; a++)
            {
                iterations++;
                for (int b = 1; b < 10; b++)
                {
                    iterations++;
                    if (a == b)
                    {
                        continue;
                    }
                    for (int c = 1; c < 10; c++)
                    {
                        iterations++;
                        if (a == c || b == c)
                        {
                            continue;
                        }

                        if (a + b + c == 15)
                        {
                            var line = new List<int> { a, b, c };

                            line.Sort();

                            if (!lines.Exists(x => x[0] == line[0] && x[1] == line[1] && x[2] == line[2]))
                            {
                                Console.WriteLine($"{line[0]} {line[1]} {line[2]}");
                                lines.Add(line);
                            }

                        }
                    }
                }
            }

            var allMagicSequars = new List<List<List<int>>>();

            foreach (var l in lines)
            {
                var magicSquare = new List<List<int>>();
                magicSquare.Add(l);
                foreach (var list in lines)
                {
                    if (magicSquare.Count == 3)
                    {
                        allMagicSequars.Add(magicSquare);
                        break;
                    }

                    if (l.Intersect(list).Count() == 0)
                    {
                        magicSquare.Add(list);
                    }
                }
            }

        }

        static void magicSquareCost(List<int> input)
        {
            int[][] allMagics = new int[][]
{new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2},
 new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4},
 new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6},
 new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8},
 new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2},
 new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6},
 new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4},
 new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8}};

            var sums = from ar in allMagics
                       select ar.Zip(input, (a, b) => Math.Abs(a - b)).Sum();

            Console.WriteLine(sums.Min());
        }

        public enum Direction { Up, Down, DiagonalUpRight, DiagonalUpLeft, DiagonalDownRight, DiagonalDownLeft, Left, Right }

        public class Line
        {
            public Point StartingLocation { get; set; }
            public Direction Direction { get; set; }

            public int HitPoints { get; set; }

            public bool IsColumnBasedIncrement =>
                (Direction == Direction.Right &&
                Direction == Direction.Left) ? true : false;

            public bool IsRowBasedIncrement => !IsColumnBasedIncrement;

            public int X => StartingLocation.X;
            public int Y => StartingLocation.Y;
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Point()
            {

            }
        }
        public static List<Line> GetPossibleMovingLines(Point queenLocation, int boardSize)
        {
            var decidingFactors = new List<Tuple<Tuple<int, int>, Direction>>();


            decidingFactors.AddRange(new List<Tuple<Tuple<int, int>, Direction>>
            {
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(1,0),Direction.Up),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(-1,0),Direction.Down),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(0,1),Direction.Right),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(0,-1),Direction.Left),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(1,1),Direction.DiagonalUpRight),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(1,-1),Direction.DiagonalUpLeft),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(-1,1),Direction.DiagonalDownRight),
                new Tuple<Tuple<int, int>, Direction>(new Tuple<int, int>(-1,-1),Direction.DiagonalDownLeft)
            });

            var lines = new List<Line>();

            decidingFactors.ForEach(d =>
            {
                if (queenLocation.X + d.Item1.Item1 < boardSize && queenLocation.Y + d.Item1.Item2 < boardSize)
                {
                    var line = new Line
                    {
                        Direction = d.Item2,
                        StartingLocation = new Point { X = queenLocation.X + d.Item1.Item1, Y = queenLocation.Y + d.Item1.Item2 }
                    };

                    switch (line.Direction)
                    {
                        case Direction.Up:
                            break;
                        case Direction.Down:
                            break;
                        case Direction.DiagonalUpRight:
                            line.HitPoints = line.X >= line.Y ? boardSize - line.X : boardSize - line.Y;
                            break;
                        case Direction.DiagonalUpLeft:
                            line.HitPoints = line.X >= line.Y ? line.X : line.Y;
                            break;
                        case Direction.DiagonalDownRight:
                            break;
                        case Direction.DiagonalDownLeft:
                            break;
                        case Direction.Left:
                            break;
                        case Direction.Right:
                            break;
                        default:
                            break;
                    }
                    if (line.Direction == Direction.Up)
                    {
                        line.HitPoints = boardSize - line.StartingLocation.X;
                    }
                    else if (line.Direction == Direction.DiagonalUpRight ||
                             line.Direction == Direction.Right ||
                             line.Direction == Direction.DiagonalDownRight)
                    {
                        line.HitPoints = boardSize - line.StartingLocation.Y;
                    }
                    else if (line.Direction == Direction.Down)
                    {
                        line.HitPoints = line.StartingLocation.X + 1;
                    }
                    else
                    {
                        line.HitPoints = line.StartingLocation.Y + 1;
                    }
                    lines.Add(line);
                }
            });

            return lines;
        }
    }
}
