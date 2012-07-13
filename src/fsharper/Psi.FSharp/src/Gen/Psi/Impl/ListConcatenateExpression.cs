//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp;
namespace JetBrains.ReSharper.Psi.FSharp.Impl.Tree {
  internal partial class ListConcatenateExpression : OperatorExpressionBase, JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpressionNode, JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpression {
    public const short LEFT_OPERAND= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 1;
    public const short FSHARP_AT= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_AT;
    public const short RIGHT_OPERAND= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 3;
    internal ListConcatenateExpression() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.LIST_CONCATENATE_EXPRESSION; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitListConcatenateExpression(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitListConcatenateExpression(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitListConcatenateExpressionNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitListConcatenateExpressionNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitListConcatenateExpressionNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.OPERATOR_AT, FSHARP_AT),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      short role = CHILD_ROLES[child.NodeType];
      if (role != 0) return role;
      JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement current = GetNextFilteredChild(null);
      if (current == null) return 0;
      if (child.parent != this) return 0;
      if (TokenBitsets.ElementBitset_0[current.NodeType]) {
        if (current == child) return LEFT_OPERAND;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.OPERATOR_AT) {
        if (current == child) return FSHARP_AT;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      if (TokenBitsets.ElementBitset_0[current.NodeType]) {
        if (current == child) return RIGHT_OPERAND;
        current = GetNextFilteredChild(current);
        if (current == null) return 0;
      } else return 0;
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression LeftOperand {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression) FindChildByRole(LEFT_OPERAND); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode LeftOperandNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode) FindChildByRole(LEFT_OPERAND); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode OperationSign {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_AT); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression RightOperand {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression) FindChildByRole(RIGHT_OPERAND); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode RightOperandNode {
      get { return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode) FindChildByRole(RIGHT_OPERAND); }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetLeftOperand (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetLeftOperandNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpression SetRightOperand (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.OPERATOR_AT) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpression)result;
      }
    }
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetRightOperandNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param)
    {
      using (JetBrains.Application.WriteLockCookie.Create (this.IsPhysical()))
      {
        TreeElement current = null, next = GetNextFilteredChild (current), result = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
        } else {
          if (next.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.OPERATOR_AT) {
            current = next;
          } else {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
          }
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          if (param == null) return null;
          result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter (this, current, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
        } else {
          if (TokenBitsets.ElementBitset_0[next.NodeType]) {
            if (param != null) {
              result = current = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            } else {
              current = GetNextFilteredChild (next);
              JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild (next);
            }
          } else {
            if (param == null) return null;
            result = (TreeElement)JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, (JetBrains.ReSharper.Psi.Tree.ITreeNode)param);
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode)result;
      }
    }
    JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpressionNode JetBrains.ReSharper.Psi.FSharp.IListConcatenateExpression.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.IBinaryExpressionNode JetBrains.ReSharper.Psi.FSharp.IBinaryExpression.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IOperatorExpressionNode JetBrains.ReSharper.Psi.FSharp.Tree.IOperatorExpression.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode JetBrains.ReSharper.Psi.FSharp.Tree.IExpression.ToTreeNode() { return this; }
    public override string ToString() {
      return "IListConcatenateExpression";
    }
  }
}