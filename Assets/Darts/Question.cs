public class Question
{
    public string Text { get; set; }
    public string[] Choices { get; set; }
    public int Answer { get; set; }
    public Question(string text, string[] choices, int answer) {
        this.Text = text;
        this.Choices = choices;
        this.Answer = answer;
    }
}