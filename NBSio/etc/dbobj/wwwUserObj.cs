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
    public string password { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }
    public int vendorId { get; set; }
    public bool isApproved { get; set; }
    public string createdDate { get; set; }

    public void clear ()
    {
      userId = 0;
      username = null;
      emailAddress = null;
      password = null;
      firstName = null;
      lastName = null;
      phoneNumber = null;
      vendorId = 0;
      isApproved = false;
      createdDate = null;
    }
  }
}
