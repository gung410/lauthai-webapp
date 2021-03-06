export class Const {
  public static readonly TABLE_ADMIN_COLUMN = [
    'id', 'name', 'pfpUrl', 'university', 'age', 'job', 'marriedStatus', 'district', 'phone', 'price', 'action'
  ];

  public static readonly TABLE_USER_COLUMN = [
    'id', 'name', 'pfpUrl', 'university', 'age', 'job', 'marriedStatus', 'district', 'phone', 'price', 'heart'
  ];

   public static readonly TABLE_ADMIN_FEEDBACK = [
    'id', 'name', 'feedbackTxt', 'contactEmail', 'dayCreated'
  ];
}
