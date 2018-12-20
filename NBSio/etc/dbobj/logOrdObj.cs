///-----------------------------------------------------------------
///   Description:    Class object for orders
///   Author:         NDW                    Date: 12/19/2018
///   Notes:          
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------


namespace NBSio.etc.dbobj
{
  public class logOrdObj
  {
    public int orderId { get; set; }
    public string orderNumber { get; set; }
    public string companyName { get; set; }
    public string customerPO { get; set; }
    public string shipDate { get; set; }
    public string shipToName { get; set; }
    public string ediStoreNumber { get; set; }
    public string shipToAddress { get; set; }
    public string shipToCity { get; set; }
    public string shipToState { get; set; }
    public string shipToZip { get; set; }
    public int totalRacks { get; set; }
  }
}
