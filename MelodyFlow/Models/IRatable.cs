namespace MelodyFlow.Models;

internal interface IRatable
{
    void AddReview(Review rate);
    double Average {  get; }
}
