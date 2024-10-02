# Распознование спама на ML.NET

На основее классификатора текста

Usage:

```
SpamRecognition spamRecognition = new SpamRecognition();

var percentage = spamRecognition.Recognize("Предлагаю подработку пиши в лс");

if(resultOfSpam >= 0.50)
{
    // Proccess
}

```
