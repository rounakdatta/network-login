from checkpoint import login
import argparse
import sys
from PyQt4 import QtCore, QtGui
from PyQt4.QtGui import *
from form import Ui_Dialog
 
class MyDialog(QtGui.QDialog):
	def __init__(self, parent=None):
		QtGui.QWidget.__init__(self, parent)
		self.ui = Ui_Dialog()
		self.ui.setupUi(self)
		self.ui.pushButton.clicked.connect(self.login)

	def login(self):
		ret = login(self.ui.lineEdit.text(), self.ui.lineEdit_2.text())
		if(ret == "ok"):
			boxy = QMessageBox()
			boxy.setText("Connected")
			boxy.exec_()
 
if __name__ == "__main__":
		app = QtGui.QApplication(sys.argv)
		myapp = MyDialog()
		myapp.show()
		sys.exit(app.exec_())

