
import 'package:flutter/material.dart';
import 'package:tictactoe/TicTacToeGame.dart';
import 'package:tictactoe/design_patterns/abstract_factory/BoardLine/ITicTacToeBoardLine.dart';


class FlutterTicTacToeBoardLine implements ITicTacToeBoardLine{

  TicTacToeGame _tictactoe;
  FlutterTicTacToeBoardLine(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe; 
  } 

  @override
  Widget render(){
    return Center(
      child: CustomPaint( //                       <-- CustomPaint widget
        size: Size(162, 162),
        painter: MyPainter(this._tictactoe),
      ),
    );

  }
}

class MyPainter extends CustomPainter { //         <-- CustomPainter class
  TicTacToeGame _tictactoe;
  MyPainter(TicTacToeGame tictactoe) { 
    this._tictactoe=tictactoe; 
  } 
  @override
  void paint(Canvas canvas, Size size) {
    final w0p1 = Offset(0, 26);
    final w0p2 = Offset(162, 26);
    final w1p1 = Offset(0, 82);
    final w1p2 = Offset(162, 82);
    final w2p1 = Offset(0, 135);
    final w2p2 = Offset(162, 135);
    final w3p1 = Offset(26, 0);
    final w3p2 = Offset(26, 162);
    final w4p1 = Offset(82, 0);
    final w4p2 = Offset(82, 162);
    final w5p1 = Offset(135, 0);
    final w5p2 = Offset(135, 162);
    final w6p1 = Offset(0, 0);
    final w6p2 = Offset(162, 162);
    final w7p1 = Offset(162, 0);
    final w7p2 = Offset(0, 162);
    final paint = Paint()
      ..color = Colors.red
      ..strokeWidth = 4;
    switch (this._tictactoe.windex) {
      case 0:
        canvas.drawLine(w0p1, w0p2, paint);  
        break;
      case 1:
        canvas.drawLine(w1p1, w1p2, paint);  
        break;
      case 2:
        canvas.drawLine(w2p1, w2p2, paint);  
        break;
      case 3:
        canvas.drawLine(w3p1, w3p2, paint);  
        break;
      case 4:
        canvas.drawLine(w4p1, w4p2, paint);  
        break;
      case 5:
        canvas.drawLine(w5p1, w5p2, paint);  
        break;
      case 6:
        canvas.drawLine(w6p1, w6p2, paint);  
        break;
      case 7:
        canvas.drawLine(w7p1, w7p2, paint);  
        break;
      default:
    }
  }

  @override
  bool shouldRepaint(CustomPainter old) {
    return (this._tictactoe.windex!=-1);
  }
}