﻿namespace Cake.Web.Docs.Comments
{
    /// <summary>
    /// Represents a <code>seealso</code> comment.
    /// </summary>
    public sealed class SeeAlsoComment : Comment
    {
        /// <summary>
        /// Gets the member.
        /// </summary>
        /// <value>The member.</value>
        public string Member { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeeAlsoComment"/> class.
        /// </summary>
        /// <param name="member">The member.</param>
        public SeeAlsoComment(string member)
        {
            Member = member;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <typeparam name="T">The context type.</typeparam>
        /// <param name="visitor">The visitor.</param>
        /// <param name="context">The context.</param>
        public override void Accept<T>(CommentVisitor<T> visitor, T context)
        {
            visitor.VisitSeeAlso(this, context);
        }
    }
}
