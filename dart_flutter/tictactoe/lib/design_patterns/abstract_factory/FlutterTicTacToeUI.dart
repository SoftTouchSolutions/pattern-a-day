import 'package:tictactoe/design_patterns/abstract_factory/ITicTacToeUIFactory.dart';
import 'package:tictactoe/design_patterns/abstract_factory/Board/ITicTacToeBoard.dart';
import 'package:tictactoe/design_patterns/abstract_factory/Board/FlutterTicTacToeBoard.dart';
import 'package:tictactoe/TicTacToeGame.dart';



class FlutterTicTacToeUI implements ITicTacToeUIFactory {
  @override
  ITicTacToeBoard getBoard(TicTacToeGame tictactoe){
    return new FlutterTicTacToeBoard(tictactoe);
  }
}