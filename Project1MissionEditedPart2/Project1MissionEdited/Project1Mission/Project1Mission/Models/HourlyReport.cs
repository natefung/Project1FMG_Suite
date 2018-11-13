using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1Mission.Models
{
    public class HourlyReport
    {
        //FMG Queue
        [DisplayName("Average Hold Time")]
        public double fmgAvgHoldTime { get; set; }
        [DisplayName("Average Speed of Answer")]
        public double fmgAvgSpeedAnswer { get; set; }
        [DisplayName("Longest Hold Time")]
        public double fmgMaxHoldTime { get; set; }
        [DisplayName("Number of Abandoned Calls")]
        public int fmgAbandoned { get; set; }
        [DisplayName("Number of Calls")]
        public int fmgNumberOfAcceptedCalls { get; set; }
        [DisplayName("% Abandoned")]
        public double fmgPercentAbandoned { get; set; }
        [DisplayName("Average Time To Abandon")]
        public double fmgAvgAbandonTime { get; set; }

        //ENT Queue
        [DisplayName("Average Hold Time")]
        public double entAvgHoldTime { get; set; }
        [DisplayName("Average Speed of Answer")]
        public double entAvgSpeedAnswer { get; set; }
        [DisplayName("Longest Hold Time")]
        public double entMaxHoldTime { get; set; }
        [DisplayName("Number of Abandoned Calls")]
        public int entAbandoned { get; set; }
        [DisplayName("Number of Calls")]
        public int entNumberOfAcceptedCalls { get; set; }
        [DisplayName("% Abandoned")]
        public double entPercentAbandoned { get; set; }
        [DisplayName("Average Time To Abandon")]
        public double entAvgAbandonTime { get; set; }

        //ALP Queue
        [DisplayName("Average Hold Time")]
        public double alpAvgHoldTime { get; set; }
        [DisplayName("Average Speed of Answer")]
        public double alpAvgSpeedAnswer { get; set; }
        [DisplayName("Longest Hold Time")]
        public double alpMaxHoldTime { get; set; }
        [DisplayName("Number of Abandoned Calls")]
        public int alpAbandoned { get; set; }
        [DisplayName("Number of Calls")]
        public int alpNumberOfAcceptedCalls { get; set; }
        [DisplayName("% Abandoned")]
        public double alpPercentAbandoned { get; set; }
        [DisplayName("Average Time To Abandon")]
        public double alpAvgAbandonTime { get; set; }
    }
}