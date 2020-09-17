/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje Ödevi
**				ÖĞRENCİ ADI............: ZÜLEYHA MÜZENNET
**				ÖĞRENCİ NUMARASI.......: G161210040
**              DERSİN ALINDIĞI GRUP...: 2B
****************************************************************************/

using System;
using System.Threading;
using System.Windows.Forms;
using WasteCollection.Infrastructure.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace WasteCollection.Infrastructure.Concrete
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _timer = new Timer {Interval = 1000};
        private TimeSpan _passingTime;
        private bool _isExpired;
        private int _score;

        #endregion

        #region Events

        public event EventHandler PassingTimeChanged;
        public event EventHandler IsExpiredChanged;
        public event EventHandler ScoreChanged;

        #endregion

        #region Properties

        public TimeSpan GameTime => TimeSpan.FromSeconds(60);

        public int Score
        {
            get => _score;
            private set
            {
                _score = value;
                ScoreChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public TimeSpan PassingTime
        {
            get => _passingTime;
            private set
            {
                _passingTime = value;
                PassingTimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public TimeSpan RemainingTime { get; private set; }

        public bool IsExpired
        {
            get => _isExpired;
            private set
            {
                _isExpired = value;
                IsExpiredChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        public Game()
        {
            _timer.Tick += PassingTimer_Tick;
        }

        public void Start()
        {
            _timer.Start();
            Score = 0;
            IsExpired = false;
        }

        public void Finish()
        {
            if (GameTime <= PassingTime)
            {
                IsExpired = false;
                _timer.Stop();
                PassingTime = new TimeSpan();
            }
        }


        private void PassingTimer_Tick(object sender, EventArgs e)
        {
            if (PassingTime > GameTime)
            {                
                IsExpired = true;
                Finish();
                return;
            }
            
            RemainingTime = GameTime - PassingTime;
            PassingTime += TimeSpan.FromSeconds(1);
        }

        public void AddScore(int score)
        {
            Score += score;
        }

        public void AddTime(TimeSpan timeSpan)
        {
            PassingTime -= timeSpan;
        }
    }
}