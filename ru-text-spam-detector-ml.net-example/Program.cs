using ru_text_spam_detector_ml.net;

SpamRecognition spamRecognition = new SpamRecognition();

Console.WriteLine("> Вводите текст придложения и получите % распознования спама");

while (true)
{
    Console.Write("> ");
    var messageFromConsole = Console.ReadLine();
    var resultOfSpam = spamRecognition.Recognize(messageFromConsole);
    Console.WriteLine($"> Процент распознования спама: {resultOfSpam}%");
}