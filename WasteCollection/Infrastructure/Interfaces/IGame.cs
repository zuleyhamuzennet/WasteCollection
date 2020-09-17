using System;

namespace WasteCollection.Infrastructure.Interfaces
{
    public interface IGame
    {
        event EventHandler PassingTimeChanged;
        event EventHandler IsExpiredChanged;
        event EventHandler ScoreChanged;
        int Score { get; }
        TimeSpan PassingTime { get; }
        TimeSpan RemainingTime { get; }
        bool IsExpired { get; }
        void Start();
        void Finish();
        void AddScore(int score);
        void AddTime(TimeSpan timeSpan);
    }
}