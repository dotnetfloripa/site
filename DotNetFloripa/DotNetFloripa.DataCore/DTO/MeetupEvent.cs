using System;

namespace DotNetFloripa.DataCore.DTO
{
    public class MeetupEvent
    {
        public long created { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int rsvp_limit { get; set; }
        public string status { get; set; }
        public long time { get; set; }
        public long? duration { get; set; }
        public long updated { get; set; }
        public int utc_offset { get; set; }
        public int waitlist_count { get; set; }
        public int yes_rsvp_count { get; set; }
        public Venue venue { get; set; }
        public Group group { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string visibility { get; set; }

        public DateTime StartTime()
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(time);
            TimeSpan utcOffset = TimeSpan.FromMilliseconds(utc_offset);
            return start.Add(utcOffset);
        }

        public DateTime EndTime()
        {
            TimeSpan howLong;

            if (duration.HasValue && duration != 0)
                howLong = TimeSpan.FromMilliseconds(duration.Value);
            else
                howLong = new TimeSpan(3, 0, 0);

            return StartTime().Add(howLong);
        }
    }

    public class Venue
    {
        public int id { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public bool repinned { get; set; }
        public string address_1 { get; set; }
        public string city { get; set; }
        public string br { get; set; }
        public string localized_country_name { get; set; }
    }

    public class Group
    {
        public long created { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string join_mode { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string urlname { get; set; }
        public string who { get; set; }
    }
}