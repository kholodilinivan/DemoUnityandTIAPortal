import QtQuick 2.7
import "qrc:/"
IGuiDialogView
{
	id: q687865857
	objId: 687865857
	x: 160
	y: 126
	width: 480
	height: 228
	qm_BorderWidth: 1
	qm_RectangleBorder.color:"#ff1c1f30"
	qm_FillColor: "#fff4f4f5"
	z:205
	captionrectX: 0
	captionrectY: 0
	captionrectWidth: 480
	captionrectHeight: 34
	captionrectBackgroundColor: "#ff3e414f"
	captionrectForegroundColor: "#ffffffff"
	captionTextX: 12
	captionTextY: 8
	captionTextWidth: 290
	captionTextHeight: 20
	qm_DisplayText: "Info text"
	IGuiListCtrl
	{
		id: qu687865857
		objectName: "qu687865857"
		x: 24
		y: 50
		width: 440
		height: 144
		qm_list.qm_linesPerRow: 1
		qm_list.qm_tableRowHeight: 13
		qm_list.qm_tableMarginLeft: 1
		qm_list.qm_tableMarginRight: 1
		qm_list.qm_tableMarginBottom: 1
		qm_list.qm_tableMarginTop: 1
		qm_list.qm_tableBackColor: "#fff5f5f5"
		qm_list.qm_tableSelectBackColor: "#fff5f5f5"
		qm_list.qm_tableAlternateBackColor: "#fff5f5f5"
		qm_list.qm_tableTextColor: "#ff13192c"
		qm_list.qm_tableSelectTextColor: "#ff13192c"
		qm_list.qm_tableAlternateTextColor: "#ff13192c"
		qm_scrollCtrl: qus687865857

		qm_hasHeader: false
		qm_hasBorder: false
		qm_hasHorizontalScrollBar: false
		qm_hasVerticalScrollBar: true
		qm_columnTypeList: [0]
		totalColumnWidth: 440
		IGuiListScrollBarCtrl
		{
			id: qus687865857

		}
	}
	modalityWidth: 320
	modalityHeight: 252
	IGuiModality{ }
	IGuiGraphicButton
	{
		id: q486539265
		objId: 486539265
		x: 446
		y: 0
		width: 34
		height: 34
		qm_BorderWidth: 1
		qm_RectangleBorder.color:"#ff1c1f30"
		qm_FillColor: "#ff464b5a"
		qm_FocusWidth: 2
		qm_FocusColor: "#ff55bfff"
		qm_ImageFillMode:6
		qm_ImagePossitionX: 2
		qm_ImagePossitionY: 2
		qm_ImageWidth: 30
		qm_ImageHeight: 30
		qm_SourceSizeWidth: 30
		qm_SourceSizeHeight: 30
	}
	IGuiQmlRectangle
	{
		id: q671088640
		objId: 671088640
		x: 1
		y: 194
		width: 478
		height: 34
		qm_BorderWidth: 0
		qm_TextColor: "#ff000000"
		qm_FillColor: "#ff3e414f"
		qm_RectangleWidth: 478
		qm_RectangleHeight: 34
	}
}
