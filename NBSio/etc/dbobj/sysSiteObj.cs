///-----------------------------------------------------------------
///   Description:    Class object for site
///   Author:         NDW                    Date: 7/27/2018
///   Notes:          
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------


namespace NBSio.etc.dbobj
{
  public class sysSiteObj
  {
    public int siteId { get; set; }
    public string description { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }
    public string phone { get; set; }
    public bool managed { get; set; }
    public bool dflt { get; set; }
  }
}
