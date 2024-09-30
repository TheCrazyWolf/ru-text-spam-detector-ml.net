using SandBox.Advanced.MachineLearn;

namespace ru_text_spam_detector_ml.net;

public class SpamRecognition
{
    public float Recognize(string? message)
    {
        //Load sample data
        var sampleData = new AntiWorkSpam.ModelInput
        {
            Value = message ?? string.Empty,
        };
        
        //Load model and predict output
        return AntiWorkSpam.Predict(sampleData).Score.Last();
    }
}

