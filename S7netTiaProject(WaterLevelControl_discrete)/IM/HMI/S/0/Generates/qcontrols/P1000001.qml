import QtQuick 2.7
import "qrc:/"
IGuiPage
{
	id: q16777217
	objId: 16777217
	x: 0
	y: 0
	width: 800
	height: 480
	IGuiButton
	{
		id: q486539310
		objId: 486539310
		x: 23
		y: 19
		width: 96
		height: 32
		qm_BorderCornerRadius: 3
		qm_BorderWidth: 2
		qm_ImageSource: "image://QSmartImageProvider/54#2#4#128#0#0"
		qm_Border.top: 15
		qm_Border.bottom: 15
		qm_Border.right: 5
		qm_Border.left: 5
		qm_FillColor: "#ff636573"
		qm_TextColor: "#ffffffff"
		qm_ValueVarTextAlignmentHorizontal: Text.AlignHCenter
		qm_ValueVarTextAlignmentVertical: Text.AlignVCenter
		qm_Anchors.bottomMargin: 2
		qm_Anchors.leftMargin: 2
		qm_Anchors.rightMargin: 2
		qm_Anchors.topMargin: 2
		qm_FocusWidth: 2
		qm_FocusColor: "#ff94b6e7"
	}
	IGuiButton
	{
		id: q486539311
		objId: 486539311
		x: 144
		y: 19
		width: 96
		height: 32
		qm_BorderCornerRadius: 3
		qm_BorderWidth: 2
		qm_ImageSource: "image://QSmartImageProvider/54#2#4#128#0#0"
		qm_Border.top: 15
		qm_Border.bottom: 15
		qm_Border.right: 5
		qm_Border.left: 5
		qm_FillColor: "#ff636573"
		qm_TextColor: "#ffffffff"
		qm_ValueVarTextAlignmentHorizontal: Text.AlignHCenter
		qm_ValueVarTextAlignmentVertical: Text.AlignVCenter
		qm_Anchors.bottomMargin: 2
		qm_Anchors.leftMargin: 2
		qm_Anchors.rightMargin: 2
		qm_Anchors.topMargin: 2
		qm_FocusWidth: 2
		qm_FocusColor: "#ff94b6e7"
	}
	IGuiTrendView
	{
		id: q469762048
		objId: 469762048
		x: 99
		y: 107
		width: 600
		height: 300
		qm_BorderCornerRadius: 4
		qm_BorderWidth: 1
		qm_RectangleBorder.color:"#ff6b717b"
		qm_FillColor: "#fff7f3f7"
		qm_FocusWidth: 2
		qm_FocusColor: "#ff94b6e7"
		rulerColor: "#7b7d84"
		rulerVisibility: true
		qm_TrendXPos: 2
		qm_TrendYPos: 2
		qm_TrendWidth: 596
		qm_TrendHeight: 195
		IGuiListCtrl
		{
			id: qu469762048
			objectName: "qu469762048"
			x: 6
			y: 235
			width: 588
			height: 59
			qm_list.qm_linesPerRow: 1
			qm_list.qm_tableRowHeight: 16
			qm_list.qm_tableMarginLeft: 3
			qm_list.qm_tableMarginRight: 1
			qm_list.qm_tableMarginBottom: 1
			qm_list.qm_tableMarginTop: 1
			qm_list.qm_tableBackColor: "#ffffffff"
			qm_list.qm_tableSelectBackColor: "#ffd6dfef"
			qm_list.qm_tableAlternateBackColor: "#ffe7e7ef"
			qm_list.qm_tableTextColor: "#ff181c31"
			qm_list.qm_tableSelectTextColor: "#ff424952"
			qm_list.qm_tableAlternateTextColor: "#ff181c31"
			qm_scrollCtrl: qus469762048

			qm_hasHeader: true
			qm_hasBorder: true
			qm_hasHorizontalScrollBar: true
			qm_hasVerticalScrollBar: true
			qm_list.qm_gridLineStyle: 0
			qm_list.qm_gridLineWidth: 1
			qm_list.qm_gridLineColor: "#ffffffff"
			qm_columnTypeList: [0, 0, 0, 0]
			totalColumnWidth: 561
			qm_headerItem: qh469762048
			IGuiListHeader
			{
				id: qh469762048
				width: 561
				qm_listItem: qu469762048
				qm_columnWidthList: [143, 106, 143, 169]
				color: "#ff84868c"
				qm_tableHeaderTextColor: "#ffffffff"
				qm_tableHeaderValueVarTextAlignmentHorizontal: Text.AlignLeft
				qm_tableHeaderValueVarTextAlignmentVertical: Text.AlignVCenter
				qm_tableHeaderMarginLeft: 3
				qm_tableHeaderMarginRight: 1
				qm_tableHeaderMarginBottom: 1
				qm_tableHeaderMarginTop: 1
				qm_noOfColumns: 4
				qm_tableHeaderHeight: 16
				qm_leftImageID: 49
				qm_leftTileTop: 4
				qm_leftTileBottom: 14
				qm_leftTileRight: 2
				qm_leftTileLeft: 4
				qm_middleImageID: 50
				qm_middleTileTop: 2
				qm_middleTileBottom: 15
				qm_middleTileRight: 2
				qm_middleTileLeft: 2
				qm_rightImageID: 51
				qm_rightTileTop: 4
				qm_rightTileBottom: 14
				qm_rightTileRight: 4
				qm_rightTileLeft: 2
				radius: 2
			}
			IGuiListScrollBarCtrl
			{
				id: qus469762048

			}
			qm_UseRowSpecificColor: true
		}
		IGuiGraphicSwitch
		{
			id: q352321536
			objId: 352321536
			x: 7
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539312
			objId: 486539312
			x: 56
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539313
			objId: 486539313
			x: 105
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539314
			objId: 486539314
			x: 154
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539315
			objId: 486539315
			x: 203
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539316
			objId: 486539316
			x: 252
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539317
			objId: 486539317
			x: 451
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539318
			objId: 486539318
			x: 500
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
		IGuiGraphicButton
		{
			id: q486539319
			objId: 486539319
			x: 549
			y: 197
			width: 44
			height: 32
			qm_BorderCornerRadius: 3
			qm_BorderWidth: 1
			qm_ImageSource: "image://QSmartImageProvider/52#2#4#128#0#0"
			qm_Border.top: 15
			qm_Border.bottom: 15
			qm_Border.right: 5
			qm_Border.left: 5
			qm_FillColor: "#ffefebef"
			qm_FocusWidth: 2
			qm_FocusColor: "#ff94b6e7"
			qm_ImageFillMode:6
			qm_ImagePossitionX: 4
			qm_ImagePossitionY: 2
			qm_ImageWidth: 38
			qm_ImageHeight: 28
			qm_SourceSizeWidth: 38
			qm_SourceSizeHeight: 28
		}
	}
}
