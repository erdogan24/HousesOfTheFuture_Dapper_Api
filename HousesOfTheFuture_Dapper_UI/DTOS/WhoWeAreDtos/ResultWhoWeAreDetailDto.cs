﻿
namespace HousesOfTheFuture_Dapper_UI.DTOS.WhoWeAreDtos
{
    public class ResultWhoWeAreDetailDto
    {
        public int WhoWeAreDetailID { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }

        internal object Select(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}