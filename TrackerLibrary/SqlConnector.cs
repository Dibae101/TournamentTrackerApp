using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        //TODO - make actual connection to database
        //saves entries to database
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
