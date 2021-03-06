﻿namespace IdleRPG.NET {
    public enum PenaltyType {
        Quit,
        Nick,
        Logout,
        Message,
        Part,
        Kick
    }
    public class Penalty {
        public PenaltyType PenaltyType { get; set; }
        public string Nick { get; set; }
        public string NewNick { get; set; }
        public string UHost { get; set; }
        public int TextLength { get; set; }
    }
}
