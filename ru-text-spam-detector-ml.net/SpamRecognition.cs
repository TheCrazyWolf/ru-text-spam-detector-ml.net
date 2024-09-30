using Ru_text_spam_detector_ml_net;

namespace ru_text_spam_detector_ml.net;

public class SpamRecognition
{
    public float Recognize(string? message)
    {
        //Load sample data
        var sampleData = new RuSpamMl.ModelInput
        {
            Message = message ?? string.Empty
        };
        
        //Load model and predict output
        return RuSpamMl.Predict(sampleData).Score.Last();
    }
}

