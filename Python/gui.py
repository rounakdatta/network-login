from checkpoint import login
import argparse
import sys
from PyQt4 import QtCore, QtGui
from PyQt4.QtGui import *
from form import Ui_Dialog
 
class MyDialog(QtGui.QDialog):
	def __init__(self, parent=None):
		QtGui.QWidget.__init__(self, parent)

		image = QtGui.QLabel(self)
		image.setGeometry(50, -100, 300, 300)
		pixmap = QtGui.QPixmap("./logo.png")
		image.setPixmap(pixmap)
		image.show()

		image2 = QtGui.QLabel(self)
		image2.setGeometry(75, 125, 300, 300)
		pixmap2 = QtGui.QPixmap("./cplogo.png")
		image2.setPixmap(pixmap2)
		image2.show()

		self.ui = Ui_Dialog()
		self.ui.setupUi(self)
		self.ui.pushButton.clicked.connect(self.login)

	def login(self):
		ret = login(self.ui.lineEdit.text(), self.ui.lineEdit_2.text())
		if(ret == "ok"):
			boxy = QMessageBox()
			boxy.setText("Connected to SRM Networks!")
			boxy.exec_()
 
if __name__ == "__main__":
		app = QtGui.QApplication(sys.argv)
		myapp = MyDialog()
		myapp.show()
		sys.exit(app.exec_())

