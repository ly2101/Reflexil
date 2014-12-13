﻿using ICSharpCode.ILSpy;
using ICSharpCode.TreeView;
using Reflexil.Utils;

namespace Reflexil.Plugins.ILSpy.ContextMenu
{
	[ExportContextMenuEntry(Icon = "resources/injectinnerenum.png", Header = "Inject inner enum", Category = "ReflexilTInnerInject")]
    internal class InjectInnerEnumContextMenu : BaseTypeDefinitionContextMenu
    {
		protected override void Execute(SharpTreeNode node)
        {
			ILSpyPackage.Inject(InjectType.Enum);
        }
    }
}
