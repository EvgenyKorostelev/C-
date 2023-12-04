// Преобразовать массив из символов в строку. [char, char, char] => charcharchar

string GetStringFromCharArray(char [] chars)
{
    string res = "";
    foreach (char item in chars) // Цикл перебирает все элементы пмассива по очереди
    {
        res += elem;
    }
    return res;
}

char [] chars = {'a','d','c','b'};
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);

// Преобразовать строку в массив симолов charcharchar => [char, char, char]

char [] StringToCharArray(string str){
    char [] chars = new char [str.Length];
    for (int i=0; i<str.Length; i++){
        chars[i] = str[i];
    }
    return chars;
}

void ShowCharsArr(char [] chars){
    foreach(char elem in chars){
        Console.Write(elem+" ");
    }
}

string str = "Hello world!";
char [] chars = StringToCharArray(str);
ShowCharsArr(chars);

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

int GetCountVovelsInString(string str){
string vovels = "aeiou";
int count = 0;
foreach(char elem in str){
    foreach(char vol in vovels){
        if(vol == elem){
            count++;
        }
    }
}
return count;
}

// Даны строки S и S0. Найти количество вхождений символов строки S0 в строку S.

int GetStringFromString(string str1, string str2){
    int count = 0;
    foreach (char elem in str1){
        foreach (char vol in str2){
            if (vol == elem){
                count++;
            }
        }
    }
    return count;
}

string str1 = "Hello";
string str2 = "QWFIKLhmqiknlf";
int chars = GetStringFromString(str1, str2);
Console.WriteLine($"Count of includes in {str1} from {str2} is {chars}");

// Определите, является ли исходная строка символов полиндромом
// (читается одинакого с начала и с конца).
// Регистры сиволов и пробелы игнорируются.

bool IsPalindrome(string msg)
{
    int len = msg.Length;
    for (int i = 0; i < len/2; i++)
    {
        if (msg[i] != msg[len-i-1])
            return false;
    }
    return true;
}