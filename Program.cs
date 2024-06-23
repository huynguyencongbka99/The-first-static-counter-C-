/*
* Ví dụ này sẽ dùng để minh họa một tính năng tính tổng số user đã được tạo ra trong chương trình của mình
* Mỗi lần tạo ra một user mới thì sẽ dùng tính năng Counter static như trên để đếm thêm một giá trị vào 
* trong biến count tĩnh. Biến này sẽ có một vùng nhớ duy nhất và bất kỳ khi nào nó được tác động thì nó đều sẽ
* tăng thêm một giá trị.
*

*/

using System;
 namespace NoNamespace
 {
    public class Counter
    {
        public static int Count = 0;
        public Counter()
        {
            Count++;
        }
    }

    class UserName
    {
        private string Name{set;get;}
        private int Id{set; get;}
        Counter x;
        public UserName(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            x = new Counter();
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Mình có thể vận dụng tính năng static để mỗi khi khởi tạo một đối tượng mới thì counter sẽ tăng lên 1
            UserName usr1 = new UserName("John1",1);
            UserName usr2 = new UserName("John1",2);
            UserName usr3 = new UserName("John1",3);
            UserName usr4 = new UserName("John1",4);
            UserName usr5 = new UserName("John1",5);
            UserName usr6 = new UserName("John1",6);
            UserName usr7 = new UserName("John1",7);
            UserName usr8 = new UserName("John1",8);

            Console.WriteLine(Counter.Count);

        }
    }
 }
