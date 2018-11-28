using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;

namespace Nursery_Production_Software.etc
{
  public class MyGridControl : GridControl
  {
    protected override BaseView CreateDefaultView()
    {
      return CreateView("MyGridView");
    }
    protected override void RegisterAvailableViewsCore(InfoCollection collection)
    {
      base.RegisterAvailableViewsCore(collection);
      collection.Add(new MyGridViewInfoRegistrator());
    }
  }
  public class MyGridViewInfoRegistrator : GridInfoRegistrator
  {
    public override string ViewName { get { return "MyGridView"; } }
    public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
  }
  public class MyGridView : GridView
  {
    public MyGridView() : this(null) { }
    public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

    protected override string ViewName { get { return "MyGridView"; } }

    protected override DevExpress.Data.Filtering.CriteriaOperator CreateAutoFilterCriterion(DevExpress.XtraGrid.Columns.GridColumn column, DevExpress.XtraGrid.Columns.AutoFilterCondition condition, object _value, string strVal)
    {
      if (column.ColumnType == typeof(String) && strVal.Length > 0)
      {
        BinaryOperatorType type = BinaryOperatorType.Like;

        string val = strVal.Replace(' ', '%') + "%";
        try
        {
          return new BinaryOperator(column.FieldName, val, type);
        }
        catch
        {
          return null;
        }
      }
      return base.CreateAutoFilterCriterion(column, condition, _value, strVal);
    }
  }
}
