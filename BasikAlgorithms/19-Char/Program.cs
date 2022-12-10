// Тип данных - Char
// Переменная типа Char может хранить в себе ровно один символ
// запись присвоенного значения обязательно в кавычках

// склейка
char c = 'a';
char b = 'd';
System.Console.WriteLine(b.ToString() + c.ToString());

if (b >= '0' && b <= '9') System.Console.WriteLine("Это цифра");
if (b >= 'A' && b <= 'Z' || b >= 'a' && b <= 'z') System.Console.WriteLine("Это буква");

if (char.IsDigit(b)) System.Console.WriteLine("Это цифра");

string s = "sdf";
// immutable string - не изменяемые строки
for (int i = 0; i < s.Length; i++)
    System.Console.WriteLine(s[i]);
// s[0]="a"; нельзя присваивать значения, как в массиве

// Что-бы произвести замену одного элемента, необходимо сперва перевести его в чарэррей
char[] cc = s.ToCharArray();
cc[0] = 'S';
s = new String(cc);

System.Text.StringBuilder sb = new System.Text.StringBuilder("asdf");
sb[0] = 's';
s = sb.ToString();
