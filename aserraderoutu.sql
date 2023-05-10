-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-11-2021 a las 04:07:58
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `aserraderoutu`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `nombreCliente` varchar(30) COLLATE utf8_bin NOT NULL,
  `ubicacionCliente` varchar(200) COLLATE utf8_bin NOT NULL,
  `fechaInscripcion` date NOT NULL DEFAULT current_timestamp(),
  `bajaCliente` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `nombreCliente`, `ubicacionCliente`, `fechaInscripcion`, `bajaCliente`) VALUES
(1, 'Intendencia de Maldonado', 'Ciudad Maldonado, departamento de Maldonado', '2021-09-01', 0),
(2, 'UTU Gregorio Aznarez', 'Ciudad Gregorio Aznarez, departamento de Maldonado', '2021-10-15', 0),
(3, 'Intendencia de Montevideo', 'Ciudad Centro, departamento de Montevideo', '2021-10-10', 0),
(4, 'UTU San Carlos', 'Ciudad de San Carlos, departamento de Maldonado', '2021-10-22', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `especie`
--

CREATE TABLE `especie` (
  `idEspecie` int(11) NOT NULL,
  `nombreEspecie` varchar(30) COLLATE utf8_bin NOT NULL,
  `descripcionEspecie` varchar(200) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `especie`
--

INSERT INTO `especie` (`idEspecie`, `nombreEspecie`, `descripcionEspecie`) VALUES
(1, 'Eucaliptus Grandis', 'Una especie normal con madera linda para tablones'),
(2, 'Pino', 'Una especie fuerte con madera pesada para muebles de calidad'),
(3, 'Alamo', 'No necesariamente empleada por su madera, sino por las nueces del árbol'),
(4, 'Eucaliptus Punctata', 'Especie excepcional para madera de carpintería');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupotroza`
--

CREATE TABLE `grupotroza` (
  `idGrupoTroza` int(11) NOT NULL,
  `diametroGrupoTroza` int(2) NOT NULL,
  `cantidadGrupoTroza` int(7) NOT NULL,
  `idRodal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `grupotroza`
--

INSERT INTO `grupotroza` (`idGrupoTroza`, `diametroGrupoTroza`, `cantidadGrupoTroza`, `idRodal`) VALUES
(1, 25, 15, 1),
(2, 35, 25, 1),
(3, 25, 0, 2),
(4, 45, 2, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lote`
--

CREATE TABLE `lote` (
  `idLote` int(11) NOT NULL,
  `cantidadProducto` int(7) NOT NULL,
  `fechaIngresoLote` date NOT NULL DEFAULT current_timestamp(),
  `cantidadTroza` int(7) NOT NULL,
  `idGrupoTroza` int(11) NOT NULL,
  `ciUsuario` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `lote`
--

INSERT INTO `lote` (`idLote`, `cantidadProducto`, `fechaIngresoLote`, `cantidadTroza`, `idGrupoTroza`, `ciUsuario`, `idProducto`) VALUES
(1, 500, '2021-11-16', 5, 1, 34578965, 7),
(2, 30, '2021-11-16', 3, 2, 58889764, 8),
(3, 200, '2021-11-16', 20, 3, 34578965, 5),
(4, 2000, '2021-11-16', 200, 4, 34578965, 6),
(5, 100, '2021-11-16', 10, 2, 58889764, 8),
(6, 200, '2021-11-18', 20, 4, 58889764, 5),
(7, 20, '2021-11-18', 10, 3, 34578965, 8),
(8, 200, '2021-11-19', 20, 3, 58889764, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `idPedido` int(11) NOT NULL,
  `fechaSolicitud` date NOT NULL,
  `fechaLimite` date NOT NULL,
  `completadoPedido` tinyint(1) NOT NULL DEFAULT 0,
  `idCliente` int(11) NOT NULL,
  `ciUsuario` int(8) NOT NULL,
  `bajaPedido` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`idPedido`, `fechaSolicitud`, `fechaLimite`, `completadoPedido`, `idCliente`, `ciUsuario`, `bajaPedido`) VALUES
(13, '2021-11-16', '2021-12-16', 1, 1, 58889764, 0),
(14, '2021-10-25', '2022-02-25', 1, 2, 58889764, 0),
(15, '2021-02-20', '2022-02-20', 0, 4, 58889764, 1),
(16, '2021-05-30', '2022-05-30', 0, 3, 58889764, 1),
(19, '2021-05-18', '2022-06-20', 0, 4, 58889764, 0),
(20, '2004-03-26', '2021-11-23', 0, 3, 58889764, 0),
(21, '2021-10-26', '2022-04-18', 0, 1, 58889764, 1),
(22, '2021-11-10', '2022-01-15', 0, 3, 58889764, 1),
(23, '2021-06-19', '2021-12-20', 0, 3, 58889764, 1),
(24, '2021-02-24', '2021-12-20', 0, 3, 58889764, 0),
(25, '2021-06-24', '2021-12-25', 0, 4, 58889764, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `idProducto` int(11) NOT NULL,
  `tipoProducto` varchar(25) COLLATE utf8_bin NOT NULL,
  `descripcionProducto` varchar(200) COLLATE utf8_bin NOT NULL,
  `ciUsuario` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`idProducto`, `tipoProducto`, `descripcionProducto`, `ciUsuario`) VALUES
(5, 'Pique de primera', 'Piques de primera calidad de 5*5*60cm', 34578965),
(6, 'Piques de segunda', 'Piques de segunda calidad de 5*5*60cm', 34578965),
(7, 'Tablas de 15', 'Tablones clasicos para carpintería 15*2.5*200cm', 34578965),
(8, 'Postes', 'Postes cilindricos de 2m de largo y 15cm de diametro', 34578965);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productospedidos`
--

CREATE TABLE `productospedidos` (
  `idProducto` int(11) NOT NULL,
  `idPedido` int(11) NOT NULL,
  `cantidadEntregada` int(11) NOT NULL,
  `cantidadSolicitada` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `productospedidos`
--

INSERT INTO `productospedidos` (`idProducto`, `idPedido`, `cantidadEntregada`, `cantidadSolicitada`) VALUES
(5, 13, 200, 200),
(5, 14, 200, 200),
(5, 15, 0, 200),
(5, 16, 0, 200),
(5, 19, 0, 200),
(5, 20, 200, 200),
(5, 21, 0, 200),
(5, 22, 0, 200),
(6, 15, 0, 20),
(6, 16, 0, 20),
(6, 19, 0, 20),
(6, 20, 0, 20),
(6, 21, 0, 20),
(6, 22, 0, 20),
(6, 24, 0, 120),
(6, 25, 0, 200),
(7, 19, 0, 500),
(7, 20, 0, 500),
(7, 21, 0, 150),
(7, 22, 0, 150),
(7, 23, 0, 200),
(7, 24, 0, 200),
(8, 19, 0, 2000),
(8, 21, 0, 35),
(8, 22, 0, 35);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro`
--

CREATE TABLE `registro` (
  `idRegistro` int(11) NOT NULL,
  `fechaSesion` date NOT NULL DEFAULT current_timestamp(),
  `descripcionRegistro` varchar(25) COLLATE utf8_bin NOT NULL DEFAULT 'Inicio de sesión',
  `ciUsuario` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `registro`
--

INSERT INTO `registro` (`idRegistro`, `fechaSesion`, `descripcionRegistro`, `ciUsuario`) VALUES
(1, '2021-11-16', 'Ingresó pedido', 58889764),
(2, '2021-11-16', 'Ingresó pedido', 58889764),
(3, '2021-11-16', 'Eliminó pedido', 58889764),
(4, '2021-11-16', 'Eliminó pedido', 58889764),
(5, '2021-11-16', 'Ingresó pedido', 58889764),
(6, '2021-11-16', 'Ingresó pedido', 58889764),
(7, '2021-11-16', 'Eliminó pedido', 58889764),
(8, '2021-11-16', 'Eliminó pedido', 58889764),
(9, '2021-11-16', 'Ingresó pedido', 58889764),
(10, '2021-11-16', 'Eliminó pedido', 58889764),
(11, '2021-11-16', 'Eliminó pedido', 58889764),
(12, '2021-11-16', 'Ingresó pedido', 58889764),
(13, '2021-11-16', 'Ingresó pedido', 58889764),
(14, '2021-11-16', 'Eliminó pedido', 58889764),
(15, '2021-11-16', 'Eliminó pedido', 58889764),
(16, '2021-11-16', 'Ingresó pedido', 58889764),
(17, '2021-11-16', 'Eliminó pedido', 58889764),
(18, '2021-11-16', 'Ingresó pedido', 58889764),
(19, '2021-11-16', 'Ingresó pedido', 58889764),
(20, '2021-11-16', 'Inició sesión', 58889764),
(21, '2021-11-16', 'Entregó productos', 58889764),
(22, '2021-11-16', 'Inició sesión', 58889764),
(23, '2021-11-16', 'Eliminó pedido', 58889764),
(24, '2021-11-16', 'Entregó productos', 58889764),
(25, '2021-11-16', 'Entregó productos', 58889764),
(26, '2021-11-16', 'Inició sesión', 58889764),
(27, '2021-11-16', 'Inició sesión', 58889764),
(28, '2021-11-16', 'Inició sesión', 58889764),
(29, '2021-11-16', 'Inició sesión', 58889764),
(30, '2021-11-16', 'Inició sesión', 58889764),
(31, '2021-11-16', 'Inició sesión', 58889764),
(32, '2021-11-16', 'Entregó productos', 58889764),
(33, '2021-11-16', 'Inició sesión', 58889764),
(34, '2021-11-16', 'Inició sesión', 58889764),
(35, '2021-11-16', 'Entregó productos', 58889764),
(36, '2021-11-16', 'Ingresó especie', 58889764),
(37, '2021-11-16', 'Modificó especie', 58889764),
(38, '2021-11-16', 'Agregó trozas a un grupo', 58889764),
(39, '2021-11-18', 'Inició sesión', 58889764),
(40, '2021-11-18', 'Entregó productos', 58889764),
(41, '2021-11-18', 'Inició sesión', 58889764),
(42, '2021-11-18', 'Entregó productos', 58889764),
(43, '2021-11-18', 'Entregó productos', 58889764),
(44, '2021-11-18', 'Inició sesión', 58889764),
(45, '2021-11-18', 'Entregó productos', 58889764),
(46, '2021-11-18', 'Entregó productos', 58889764),
(47, '2021-11-18', 'Inició sesión', 58889764),
(48, '2021-11-18', 'Entregó productos', 58889764),
(49, '2021-11-18', 'Inició sesión', 58889764),
(50, '2021-11-18', 'Entregó productos', 58889764),
(51, '2021-11-18', 'Entregó productos', 58889764),
(52, '2021-11-18', 'Entregó productos', 58889764),
(53, '2021-11-18', 'Ingresó Lote', 58889764),
(54, '2021-11-18', 'Entregó productos', 58889764),
(55, '2021-11-18', 'Inició sesión', 34578965),
(56, '2021-11-18', 'Ingresó Lote', 34578965),
(57, '2021-11-18', 'Inició sesión', 58889764),
(58, '2021-11-19', 'Inició sesión', 58889764),
(59, '2021-11-19', 'Entregó productos', 58889764),
(60, '2021-11-19', 'Inició sesión', 58889764),
(61, '2021-11-19', 'Inició sesión', 58889764),
(62, '2021-11-19', 'Inició sesión', 58889764),
(63, '2021-11-19', 'Inició sesión', 58889764),
(64, '2021-11-19', 'Inició sesión', 58889764),
(65, '2021-11-19', 'Inició sesión', 58889764),
(66, '2021-11-19', 'Inició sesión', 58889764),
(67, '2021-11-19', 'Ingresó Lote', 58889764),
(68, '2021-11-19', 'Inició sesión', 58889764),
(69, '2021-11-19', 'Entregó productos', 58889764),
(70, '2021-11-19', 'Inició sesión', 58889764),
(71, '2021-11-19', 'Inició sesión', 58889764),
(72, '2021-11-19', 'Inició sesión', 58889764),
(73, '2021-11-19', 'Inició sesión', 58889764),
(74, '2021-11-19', 'Inició sesión', 58889764),
(75, '2021-11-19', 'Inició sesión', 58889764),
(76, '2021-11-19', 'Inició sesión', 58889764),
(77, '2021-11-19', 'Inició sesión', 58889764),
(78, '2021-11-19', 'Inició sesión', 58889764),
(79, '2021-11-19', 'Inició sesión', 58889764),
(80, '2021-11-19', 'Inició sesión', 58889764),
(81, '2021-11-19', 'Inició sesión', 58889764),
(82, '2021-11-19', 'Inició sesión', 58889764),
(83, '2021-11-19', 'Inició sesión', 58889764),
(84, '2021-11-19', 'Inició sesión', 58889764),
(85, '2021-11-19', 'Inició sesión', 58889764),
(86, '2021-11-19', 'Inició sesión', 58889764),
(87, '2021-11-19', 'Inició sesión', 58889764),
(88, '2021-11-19', 'Inició sesión', 58889764),
(89, '2021-11-19', 'Inició sesión', 58889764),
(90, '2021-11-19', 'Inició sesión', 58889764),
(91, '2021-11-19', 'Inició sesión', 58889764),
(92, '2021-11-19', 'Inició sesión', 58889764),
(93, '2021-11-19', 'Inició sesión', 58889764),
(94, '2021-11-19', 'Inició sesión', 58889764),
(95, '2021-11-19', 'Inició sesión', 58889764),
(96, '2021-11-19', 'Inició sesión', 58889764),
(97, '2021-11-19', 'Inició sesión', 58889764),
(98, '2021-11-19', 'Inició sesión', 58889764),
(99, '2021-11-19', 'Inició sesión', 58889764),
(100, '2021-11-19', 'Agregó trozas a un grupo', 58889764),
(101, '2021-11-19', 'Inició sesión', 58889764),
(102, '2021-11-19', 'Inició sesión', 58889764),
(103, '2021-11-19', 'Inició sesión', 58889764),
(104, '2021-11-19', 'Inició sesión', 58889764),
(105, '2021-11-19', 'Inició sesión', 58889764),
(106, '2021-11-19', 'Inició sesión', 58889764),
(107, '2021-11-19', 'Inició sesión', 58889764),
(108, '2021-11-19', 'Inició sesión', 58889764),
(109, '2021-11-19', 'Inició sesión', 58889764),
(110, '2021-11-19', 'Inició sesión', 58889764),
(111, '2021-11-19', 'Inició sesión', 58889764),
(112, '2021-11-19', 'Inició sesión', 58889764),
(113, '2021-11-19', 'Inició sesión', 58889764),
(114, '2021-11-19', 'Inició sesión', 58889764),
(115, '2021-11-19', 'Inició sesión', 58889764),
(116, '2021-11-19', 'Inició sesión', 58889764),
(117, '2021-11-19', 'Inició sesión', 58889764),
(118, '2021-11-19', 'Inició sesión', 58889764),
(119, '2021-11-19', 'Inició sesión', 58889764),
(120, '2021-11-19', 'Inició sesión', 58889764),
(121, '2021-11-19', 'Inició sesión', 58889764),
(122, '2021-11-19', 'Inició sesión', 58889764),
(123, '2021-11-19', 'Inició sesión', 58889764),
(124, '2021-11-19', 'Inició sesión', 58889764),
(125, '2021-11-19', 'Inició sesión', 58889764),
(126, '2021-11-19', 'Inició sesión', 58889764),
(127, '2021-11-19', 'Inició sesión', 58889764),
(128, '2021-11-19', 'Inició sesión', 58889764),
(129, '2021-11-19', 'Inició sesión', 58889764),
(130, '2021-11-19', 'Inició sesión', 58889764),
(131, '2021-11-19', 'Inició sesión', 58889764),
(132, '2021-11-19', 'Inició sesión', 58889764),
(133, '2021-11-19', 'Inició sesión', 58889764),
(134, '2021-11-19', 'Inició sesión', 58889764),
(135, '2021-11-19', 'Inició sesión', 58889764),
(136, '2021-11-19', 'Inició sesión', 58889764),
(137, '2021-11-19', 'Inició sesión', 58889764),
(138, '2021-11-19', 'Inició sesión', 58889764),
(139, '2021-11-19', 'Inició sesión', 58889764),
(140, '2021-11-19', 'Inició sesión', 58889764),
(141, '2021-11-20', 'Inició sesión', 58889764);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rodal`
--

CREATE TABLE `rodal` (
  `idRodal` int(11) NOT NULL,
  `dimensionesRodal` int(6) NOT NULL,
  `idEspecie` int(11) NOT NULL,
  `ciUsuario` int(8) NOT NULL,
  `bajaRodal` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `rodal`
--

INSERT INTO `rodal` (`idRodal`, `dimensionesRodal`, `idEspecie`, `ciUsuario`, `bajaRodal`) VALUES
(1, 50, 3, 78942514, 0),
(2, 200, 1, 78942514, 0),
(3, 150, 4, 78942514, 0),
(4, 500, 2, 78942514, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `idTipo` int(11) NOT NULL,
  `nombreTipo` varchar(30) COLLATE utf8_bin NOT NULL,
  `descripcionTipo` varchar(150) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`idTipo`, `nombreTipo`, `descripcionTipo`) VALUES
(1, 'Administrador Avanzado', 'Posee los permisos para hacer uso de todas las funciones disponibles, incluyendo el acceso a los ajustes'),
(2, 'Administrador Carpintería', 'Puede utilizar todas las funciones disponibles dentro de los siguientes menús: Lotes y Productos'),
(3, 'Administrador Forestal', 'Puede utilizar todas las funciones disponibles dentro de los siguientes menús: Trozas, Pedidos, Clientes, Especies y Rodales'),
(4, 'Estandar', 'Posee únicamente los permisos para ver los datos ingresados al sistema, pero no cuenta con ninguna opción');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `ciUsuario` int(8) NOT NULL,
  `nombreUsuario` varchar(30) COLLATE utf8_bin NOT NULL,
  `contrasenaUsuario` varchar(32) COLLATE utf8_bin NOT NULL,
  `telefonoUsuario` int(9) NOT NULL,
  `correoUsuario` varchar(200) COLLATE utf8_bin NOT NULL,
  `idTipo` int(11) NOT NULL,
  `bajaUsuario` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`ciUsuario`, `nombreUsuario`, `contrasenaUsuario`, `telefonoUsuario`, `correoUsuario`, `idTipo`, `bajaUsuario`) VALUES
(34578965, 'Nombre Carpintero', 'tablonamigo', 97854415, 'Tablade15@carpintero.com', 2, 0),
(45712580, 'Nombre Estandar', 'notengonada', 94235471, 'alguienAburrido@yahoo.com', 4, 0),
(58889764, 'Nombre Avanzado', '1235', 9345678, 'Jose@gmail.com', 1, 0),
(78942514, 'Nombre Forestal', 'trozaamiga', 65474882, 'ArbolesComoPasion@gmail.com', 3, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `especie`
--
ALTER TABLE `especie`
  ADD PRIMARY KEY (`idEspecie`);

--
-- Indices de la tabla `grupotroza`
--
ALTER TABLE `grupotroza`
  ADD PRIMARY KEY (`idGrupoTroza`),
  ADD KEY `IdRodal` (`idRodal`);

--
-- Indices de la tabla `lote`
--
ALTER TABLE `lote`
  ADD PRIMARY KEY (`idLote`),
  ADD KEY `IdGTroza` (`idGrupoTroza`),
  ADD KEY `CiUsuario` (`ciUsuario`),
  ADD KEY `IdProducto` (`idProducto`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`idPedido`),
  ADD KEY `CiUsuario` (`ciUsuario`),
  ADD KEY `IdCliente` (`idCliente`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`idProducto`),
  ADD KEY `CiUsuario` (`ciUsuario`);

--
-- Indices de la tabla `productospedidos`
--
ALTER TABLE `productospedidos`
  ADD PRIMARY KEY (`idProducto`,`idPedido`),
  ADD KEY `idPedido` (`idPedido`);

--
-- Indices de la tabla `registro`
--
ALTER TABLE `registro`
  ADD PRIMARY KEY (`idRegistro`),
  ADD KEY `CiUsuario` (`ciUsuario`);

--
-- Indices de la tabla `rodal`
--
ALTER TABLE `rodal`
  ADD PRIMARY KEY (`idRodal`),
  ADD KEY `IdEspecie` (`idEspecie`),
  ADD KEY `CiUsuario` (`ciUsuario`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`idTipo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`ciUsuario`),
  ADD KEY `idTipo` (`idTipo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `especie`
--
ALTER TABLE `especie`
  MODIFY `idEspecie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `grupotroza`
--
ALTER TABLE `grupotroza`
  MODIFY `idGrupoTroza` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `lote`
--
ALTER TABLE `lote`
  MODIFY `idLote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `idPedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `idProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `registro`
--
ALTER TABLE `registro`
  MODIFY `idRegistro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=142;

--
-- AUTO_INCREMENT de la tabla `rodal`
--
ALTER TABLE `rodal`
  MODIFY `idRodal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  MODIFY `idTipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `grupotroza`
--
ALTER TABLE `grupotroza`
  ADD CONSTRAINT `grupotroza_ibfk_1` FOREIGN KEY (`idRodal`) REFERENCES `rodal` (`idRodal`);

--
-- Filtros para la tabla `lote`
--
ALTER TABLE `lote`
  ADD CONSTRAINT `lote_ibfk_1` FOREIGN KEY (`idGrupoTroza`) REFERENCES `grupotroza` (`idGrupoTroza`),
  ADD CONSTRAINT `lote_ibfk_2` FOREIGN KEY (`ciUsuario`) REFERENCES `usuario` (`ciUsuario`),
  ADD CONSTRAINT `lote_ibfk_3` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`);

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`ciUsuario`) REFERENCES `usuario` (`ciUsuario`),
  ADD CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`ciUsuario`) REFERENCES `usuario` (`ciUsuario`);

--
-- Filtros para la tabla `productospedidos`
--
ALTER TABLE `productospedidos`
  ADD CONSTRAINT `productospedidos_ibfk_1` FOREIGN KEY (`idPedido`) REFERENCES `pedido` (`idPedido`),
  ADD CONSTRAINT `productospedidos_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`);

--
-- Filtros para la tabla `registro`
--
ALTER TABLE `registro`
  ADD CONSTRAINT `registro_ibfk_1` FOREIGN KEY (`ciUsuario`) REFERENCES `usuario` (`ciUsuario`);

--
-- Filtros para la tabla `rodal`
--
ALTER TABLE `rodal`
  ADD CONSTRAINT `rodal_ibfk_1` FOREIGN KEY (`idEspecie`) REFERENCES `especie` (`idEspecie`),
  ADD CONSTRAINT `rodal_ibfk_2` FOREIGN KEY (`ciUsuario`) REFERENCES `usuario` (`ciUsuario`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idTipo`) REFERENCES `tipousuario` (`idTipo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
