using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;

namespace Nursery_Production_Software.etc
{
  public class NBSGrid : GridControl
  {
    protected override BaseView CreateDefaultView()
    {
      return CreateView("NBSGridView");
    }
    protected override void RegisterAvailableViewsCore(InfoCollection collection)
    {
      base.RegisterAvailableViewsCore(collection);
      collection.Add(new NBSGridViewInfoRegistrator());
    }
  }
  public class NBSGridViewInfoRegistrator : GridInfoRegistrator
  {
    public override string ViewName { get { return "NBSGridView"; } }
    public override BaseView CreateView(GridControl grid) { return new NBSGridView(grid as GridControl); }
  }
  public class NBSGridView : GridView
  {
    public NBSGridView() : this(null) { }
    public NBSGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

    protected override string ViewName { get { return "NBSGridView"; } }

    protected override DevExpress.Data.Filtering.CriteriaOperator CreateAutoFilterCriterion(DevExpress.XtraGrid.Columns.GridColumn column, DevExpress.XtraGrid.Columns.AutoFilterCondition condition, object _value, string strVal)
    {
      if (column.ColumnType == typeof(String) && strVal.Length > 0)
      {
        BinaryOperatorType type = BinaryOperatorType.Like;

        string val = "%" + strVal.Replace(' ', '%') + "%";
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
