Module main

    Sub Main()




        Dim ltotal3 As Long = Enumerable.Range(1, 10 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        Dim ltotal5 As Long = Enumerable.Range(1, 10 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        Dim ltotal15 As Long = Enumerable.Range(1, 10 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)


        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)


        ltotal3 = Enumerable.Range(1, 100 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = Enumerable.Range(1, 100 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = Enumerable.Range(1, 100 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)


        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)



        ltotal3 = Enumerable.Range(1, 1000 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = Enumerable.Range(1, 1000 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = Enumerable.Range(1, 1000 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)


        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)

        ltotal3 = Enumerable.Range(1, 10000 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = Enumerable.Range(1, 10000 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = Enumerable.Range(1, 10000 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)


        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)

        ltotal3 = Enumerable.Range(1, 100000 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = Enumerable.Range(1, 100000 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = Enumerable.Range(1, 100000 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)


        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)


        ltotal3 = RangeBy(1, 1000000 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = RangeBy(1, 1000000 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = RangeBy(1, 1000000 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)

        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)



        ltotal3 = RangeBy(1, 10000000 - 1).Where(Function(x) (x Mod 3) = 0).Sum(Function(x) x)
        ltotal5 = RangeBy(1, 10000000 - 1).Where(Function(x) (x Mod 5) = 0).Sum(Function(x) x)
        ltotal15 = RangeBy(1, 10000000 - 1).Where(Function(x) (x Mod 15) = 0).Sum(Function(x) x)

        Console.WriteLine(ltotal3 + ltotal5 - ltotal15)

        Console.ReadKey()


    End Sub



    Public Iterator Function RangeBy(ByVal start As Long, ByVal count As Long) As IEnumerable(Of Long)
        While Math.Max(Threading.Interlocked.Decrement(count), count + 1) > 0
            Yield start
            start += 1 'by
        End While
    End Function




End Module

'// ***
'// *** Long Extensions
'// ***
'Public Static IEnumerable<Long> Range(this Long start, Long count) => start.RangeBy(count, 1);
'Public Static IEnumerable<Long> RangeBy(this Long start, Long count, Long by) {
'    For (; count-- > 0; start += by)
'        yield return start;
'}
'Public Static IEnumerable<Long> To(this Long start, Long finish) => start.ToBy(finish, 1);
'Public Static IEnumerable<Long> ToBy(this Long start, Long End, Long by) {
'    var absBy = Math.Abs(by);
'    If (start <= end)
'        For (; start <= end; start += by)
'            yield return start;
'    Else
'For (; start >= end; start -= by)
'            yield return start;
'}
'Public Static IEnumerable<Long> DownTo(this Long start, Long finish) => start.ToBy(finish, 1);
'Public Static IEnumerable<Long> DownToBy(this Long start, Long min, Long by) => start.ToBy(min, by);

'Static void Main(String[] args) {

'        int t = 0; //Convert.ToInt32(Console.ReadLine());
'        Long r = 0;

'        int.TryParse(Console.ReadLine(), out t);
'        List<int> lr = new List<int>();

'        //System.Diagnostics.Debug.Print(t.ToString());
'        lr.Add(0);


'        //if (t > System.Math.Pow(10,5)) t = System.Math.Pow(10,5);
'       // if (t <1) t = 1;

'        for(int a = 0; a <t; a++){

'            r = 0;

'            Long n = Convert.ToInt64(Console.ReadLine());
'            If (n >= 1 && n <= System.Math.Pow(10, 9)) {
'           r = Enumerable.Range < Long > (1, n).Where((x) >= ((x % 3) == 0 || (x % 5) == 0)).Sum();


'            }



'            //int.TryParse(Console.ReadLine(), out n);

'             //if (n > System.Math.Pow(10,9)) n = System.Math.Pow(10,9);
'             //if (n < 1) n = 1;

'             //(input > date1 && input < date2)
'             /*
'             If (n >= 1 && n <= System.Math.Pow(10, 9)) {

'                For (Long i = 1; i < n; i++) {
'                    If ((i % 3) == 0 || (i % 5) == 0)  {   
'                        r += i;
'                    }
'                }  
'             }
'             */
'                /*

'                For (int i = 0; i < n; i+=3) {
'                    //i += 3;
'                    If (i < n) {   
'                        If (!lr.Contains(i))
'                        {
'                            r += i;
'                            lr.Add(i);    
'                        }                        
'                    }
'                }  

'                For (int i = 0; i < n; i+=5) {                    
'                    If (i < n) { 
'                       If (!lr.Contains(i))
'                        {
'                            r += i;
'                            lr.Add(i);    
'                        } 
'                    }
'                }
'            */


'              Console.WriteLine(r);

'            /*
'            Console.WriteLine();
'            Console.Write("Total: ");
'            */
'            /*
'            If (lr.Count() > 0)
'            {


'               //     var r = lr.Distinct().Aggregate( (sum, x) => sum + x))

'                //Console.WriteLine(r);
'                Console.WriteLine(lr.Select(o >= o).Sum());
'            }
'            */
'            //Console.WriteLine();
'            //lr = New List<long>();
'            //lr.Clear();
'            //lr.Add(0);
'        }