///-----------------------------------------------------------------
///   Description:    Class object for site
///   Author:         NDW                    Date: 7/27/2018
///   Notes:          
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------


namespace NBSio.etc.dbobj
{
  public class wwwUserObj
  {
    public int userId { get; set; }
    public string username { get; set; }
    public string emailAddress { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    public string vendorName { get; set; }
    public bool isApproved { get; set; }
    public string createdDate { get; set; }
  }
}
