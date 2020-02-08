import 'package:tictactoe/design_patterns/abstract_factory/Board/ITicTacToeBoard.dart';
import 'package:tictactoe/TicTacToeGame.dart';


abstract class ITicTacToeUIFactory {
  ITicTacToeBoard getBoard(TicTacToeGame tictactoe);
}