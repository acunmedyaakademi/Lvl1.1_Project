internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Hoşgeldin----\n\n----Başlayalım mı?----\n");
        Console.WriteLine("1 - Başlayalım :)");
        Console.WriteLine("2 - Vazgeçtim Şuan Kendime Güvenmiyorum.");
        int choose = Convert.ToInt16(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Home();
                break;
            case 2:
                Console.WriteLine("Tekrar soruyorum Emin misin? Eminsen Enter 'a bas");
                Console.ReadKey();
                break;
        }
    }

    public static void Home()
    {
        Console.Clear();
        List<Exams> questions = new List<Exams>();

        questions.Add(CreateQuestion("1- C# ta 'string, class, interface' gibi tipler ne tipidir?", new List<string> { "a) Referans Tipleridir.", "b) Değer Tipleridir.", "c) Tip Değillerdir.", "d) Referans Tipleri Değillerdir." }, "a", 10)); Console.Clear();
        questions.Add(CreateQuestion("2- C# programlama dilinde 'foreach' döngüsü ne amaçla kullanılır?", new List<string> { "a) Dizileri ters çevirmek için kullanılır.", "b) Bir dizi içindeki her elemana erişmek ve üzerinde işlem yapmak için kullanılır.", "c) İki sayının toplamını hesaplamak için kullanılır.", "d) Ekrana metin yazmak için kullanılır." }, "b", 10)); Console.Clear();
        questions.Add(CreateQuestion("3- C# dilinde bir döngüyü belirli bir koşul sağlanana kadar çalıştırmak için hangi döngü yapısı kullanılır?", new List<string> { "a) for döngüsü", "b) while döngüsü", "c) foreach döngüsü", "d) if döngüsü" }, "b", 10)); Console.Clear();
        questions.Add(CreateQuestion("4- C# programlama dilinde hangi operatör iki değeri karşılaştırmak ve eşitlik durumunu kontrol etmek için kullanılır?", new List<string> { "a) < operatörü", "b) > operatörü", "c) == operatörü", "d) != operatörü" }, "c", 10)); Console.Clear();
        questions.Add(CreateQuestion("5- C# programlama dilinde hangisi bir erişim belirleyici (access modifier) DEĞİLDİR?", new List<string> { "a) public", "b) protected", "c) private", "d) static" }, "d", 10)); Console.Clear();
        questions.Add(CreateQuestion("6- C# dilinde bir dizi (array) tanımlarken elemanların veri tipi belirlemek zorunlu mudur?", new List<string> { "a) Evet, zorunludur.", "b) Hayır, veri tipi belirtmek isteğe bağlıdır.", "c) Veri tipi otomatik olarak belirtilir.", "d) Dizilerde veri tipi kullanılmaz." }, "a", 10));Console.Clear();
        questions.Add(CreateQuestion("7- C# dilinde bir nesneyi bellekten temizlemek ve işlemi sonlandırmak için hangi metod kullanılır?", new List<string> { "a) dispose()", "b) close()", "c) end()", "d) finish()" }, "a", 10)); Console.Clear();
        questions.Add(CreateQuestion("8- C# dilinde 'interface' nedir?", new List<string> { "a) Sınıfların belirli metotları ve özellikleri uygulamalarını sağlar.", "b) Bir veri türüdür", "c) Bir döngüdür", "d) Hepsi" }, "a", 10)); Console.Clear();
        questions.Add(CreateQuestion("9- C# dilinde 'new' işlemi nedir ve ne işe yarar?", new List<string> { "a) Bir değişkenin değerini sıfırlar.", "b) Bir nesne örneği oluşturur ve bellekte yer ayırır.", "c) Bir Metodu başlatır ve çalıştırır.", "d) Bir döngüyü sonlandırır." }, "b", 10)); Console.Clear();
        questions.Add(CreateQuestion("10- C# dilinde 'int a = 4' ve 'int b = 6' değişkenleri verildiğinde, 'a+b=c' ise 'c' değişkeninin değeri nedir?", new List<string> { "a) 50", "b) 6", "c) 24", "d) 10" }, "d", 10)); Console.Clear();

        int totalScore = TotalScore(questions);
        Console.WriteLine("Total Score: " + totalScore);
        if (totalScore >= 50) Console.WriteLine("Geçtiniz");
        else Console.WriteLine("Kaldınız");
        Console.WriteLine("Çıkmak için ENTER'a Basınız");
        Console.ReadKey();
    }

    public static Exams CreateQuestion(string question, List<string> choices, string correctAnswer, int score)
    {
        
        Console.WriteLine(question);

        foreach (var choice in choices)
        {
            Console.WriteLine(choice);
        }

        string answer = Console.ReadLine();

        return new Exams(question, choices, correctAnswer, answer, score);
    }

    public static int TotalScore(List<Exams> questions)
    {
        int totalScore = 0;
        foreach (var question in questions)
        {
            if (question.Answer == question.CorrectAnswer)
            {
                totalScore += question.Puan;
            }
        }
        return totalScore;
    }
}

class Exams
{
    public string Questions { get; set; }
    public List<string> Choices { get; set; }
    public string CorrectAnswer { get; set; }
    public string Answer { get; set; }
    public int Puan { get; set; }

    public Exams(string question, List<string> choices, string correctAnswer, string answer, int score)
    {
        Questions = question;
        Choices = choices;
        CorrectAnswer = correctAnswer;
        Answer = answer;
        Puan = score;
    }
}
